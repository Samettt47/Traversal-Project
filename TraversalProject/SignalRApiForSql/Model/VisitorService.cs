using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApiForSql.DAL;
using SignalRApiForSql.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiForSql.Model
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
            await _hubContext.Clients.All.SendAsync("ReceiveVisitorList", GetVisitorChartList());
        }

        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            { // SORGU KOMUTU OLUŞTURMAK ICIN BUNU YAPTIK

                command.CommandText = "Select tarih , [1] , [2] , [3] , [4] , [5] from (select [City] ,  CityvisitCount , Cast([VisitDate] as Date) as tarih from Visitors) as visitTable Pivot (Sum(CityvisitCount) For City in([1] , [2] , [3] , [4] , [5])) as pivottable order by tarih asc";
                command.CommandType = System.Data.CommandType.Text; // yazılacak sorguyu text olarak gönder
                _context.Database.OpenConnection(); // BAĞLANTIYI AC 
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) // ISLEM DEVAM ETTIGI MUDDETCE
                    {
                        VisitorChart visitorChart = new VisitorChart();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString(); //HER BİR SEHİR İÇİN TÜM TARİHLERİ
                                                                                            //HER BİR ŞEHİR İÇİN TEK TEK BÜTÜN TARİHLERİ TANIMLADIK
                        Enumerable.Range(1, 5).ToList().ForEach(x => {

                            if (DBNull.Value.Equals(reader[x])) // EGERKI GELEN X DEGERI NULL 'SA 
                            {
                                visitorChart.Counts.Add(0);  // SEN BUNU 0 YAP AKSİ DURUMDA BAŞKA ŞEKİLDE YAP
                            }
                            else
                            {
                                visitorChart.Counts.Add(reader.GetInt32(x));
                            }
                           

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
