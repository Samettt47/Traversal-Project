using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Model
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<VisitorHub> _hubContext;

        public VisitorService(Context context, IHubContext<VisitorHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        public IQueryable<Visitor> GetList() // queryable olması sebebi burada elle komut gireceğimiz için list yapmadık
        {
            return _context.Visitors.AsQueryable();
        }
        public async Task SaveVisitor(Visitor visitor) // VERİLERİMİZİ KAYDEDECEK.
        {
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("CallVisitorList" , "aaa");
        }
        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using(var command = _context.Database.GetDbConnection().CreateCommand()){ // SORGU KOMUTU OLUŞTURMAK ICIN BUNU YAPTIK

                command.CommandText = "Select * from crosstab ( 'Select VisitDate , City , CityvisitCount From Visitors Order by 1, 2' ) As ct(VisitDate Date , City1 int , City2 int , City3 int, City4 int , City5 int);";
                command.CommandType = System.Data.CommandType.Text; // yazılacak sorguyu text olarak gönder
                _context.Database.OpenConnection(); // BAĞLANTIYI AC 
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) // ISLEM DEVAM ETTIGI MUDDETCE
                    {
                        VisitorChart visitorChart = new VisitorChart();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString(); //HER BİR SEHİR İÇİN TÜM TARİHLERİ
                                                                                            //HER BİR ŞEHİR İÇİN TEK TEK BÜTÜN TARİHLERİ TANIMLADIK
                        Enumerable.Range(1, 5).ToList().ForEach(x=> {

                            visitorChart.Counts.Add(reader.GetInt32(x));
                        
                        }); // ENUM DAKİ 5 TANE ŞEHİR OLDUGU ICIN 1 DEN 5 E KADAR ARALIGI BELIRLEDIK
                        visitorCharts.Add(visitorChart); // ANA LİSTEYE EKLEDİK BU TANIMLADIGIMIZ SEHİRLERİ. GRAFİĞE ICIN TANIMLADIK.
                    }
                    
                }
                _context.Database.CloseConnection();
                return visitorCharts;
               
            }

        }

    }
}
