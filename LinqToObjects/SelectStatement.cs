using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{

    internal class Comune

    {
        public string Name;
        public string Provincia;
        public string Regione;
        public int abitanti;
    }
    internal class SelectStatement
    {
        static List<Comune> comuni = new List<Comune>()
        {
            new() { Name = "Corsico", Provincia = "Milano", Regione = "Lombardia", abitanti = 10000 },
            new() { Name = "Sesto", Provincia = "Milano", Regione = "Lombardia", abitanti = 60000 },
            new() { Name = "Lodi", Provincia = "Lodi", Regione = "Lombardia", abitanti = 20000 },
            new() { Name = "Rho", Provincia = "Milano", Regione = "Lombardia", abitanti = 80000 }
        };


        internal static List<string> SelectStatemnt(string Provincia)
        {
            //Provincia == "Milano" 
            var result = (from c in comuni
                          where c.Provincia == Provincia //  3 comuni
                          select c.Regione) // result 3 record per il campo REGIONE
                                            //.Distinct().ToList();  // Filtra 
                           .ToList();
            return result;

        }
        internal static void SelectTupleByRegione(string Provincia)
        {
            List<(string Regione, int abitanti)> result =
                (from c in comuni
                 where c.Provincia == Provincia //  3 comuni
                 select new { c.Regione, c.abitanti })  // Crea un lista di coppia Iterable 
                      .Select(r => (r.Regione, r.abitanti)).ToList();  // Tipizzato LIST<string,Int>

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Regione} | {item.abitanti}");

            }
        }
        internal static void InlineQuery(string Provincia)
        {
            comuni
                 .Where(c => c.Provincia == Provincia)
                     .Select(i => new { i.Regione, i.Provincia })
                     .Distinct()
                     .OrderByDescending(i => i.Regione)
                     .ToList()
                     .ForEach(c =>
                     {
                         Console.Write(c.Provincia);
                         Console.Write("//");
                         Console.WriteLine(c.Regione);

                     });
                    
        }
        internal static void SelectTupleByComune(string Provincia)
        {
            List<(string Regione, int Abitanti)> result =

                (from c in comuni
                 where c.Provincia == Provincia //  3 comuni
                 select new { c.Regione, c.abitanti }).Select(r => (r.Regione, r.abitanti)).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Regione} | {item.Abitanti}");
            }
            Console.WriteLine("---------------------------------------");
            GroupTuple(result);
        }
        internal static void GroupTuple(List<(string Regione, int abitanti)> Tuple)
        {
            foreach (var t in Tuple.GroupBy(info => info.Regione).Select(
                          group => new
                          {
                              Group = group.Key,
                              Total = group.Sum(a => a.abitanti).ToString(),
                              Count = group.Count()
                          })
                         .OrderBy(x => x.Group))
            {
                Console.WriteLine($"Regione : {t.Group}");
                Console.WriteLine($"N° Abitanti: {t.Total}");
                Console.WriteLine($"Tot Province: {t.Count}");


            }

        }
        internal static void CreateStructure()
        {
            var ProvinceDict = (from c in comuni
                                group c by c.Provincia // if Provincia are 5 it will return  5 Groups  of  item
                              into cg  // put the Groups into a where table Key Field  is the "grouped by" Field
                                orderby cg.Key ascending  // Order by Regione ascendente 
                                select new { cg.Key, cg }).ToList()// Create a couple to be able to iterate
                                       .ToDictionary(i => i.Key, i => i.cg.ToList());




            var RegionsDict = (from c in comuni  // 10
                               group c by c.Regione // if Regione are 5 it will return  5 Groups  of  item 
                               into rg // put the Groups into a where table Key Field  is the "grouped by" Field
                               orderby rg.Key descending  // Order by Regione Decrescente 
                               select new { rg.Key, rg }).ToList() // Create a couple to be able to iterate
                                             .ToDictionary(i => i.Key, i => i.rg.Select(o => o.Provincia)
                                                 // .Distinct()
                                                 .ToList());

            System.Console.WriteLine("Ciao");
            System.Console.WriteLine("Ciao from Ioc");

        }
    }

}
