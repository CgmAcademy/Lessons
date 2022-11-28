using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    internal class NestedGroupJoin
    {  
        public static void JoinTables()
        {
            var Materie = new List<Materia>
            {
                new Materia { MateriaID =1, Nome = "Matematica" },
                new Materia { MateriaID =2, Nome = "Storia" },
                new Materia { MateriaID =3, Nome = "Scienze" }
            };

            var Corsi = new List<Corso>
            {
                new Corso { MateriaStudenteID =1, MateriaID = 2, StudenteID = 1000 },
                new Corso { MateriaStudenteID =2, MateriaID = 1, StudenteID = 1001 },
                new Corso { MateriaStudenteID =3, MateriaID = 3, StudenteID = 1003 },
                new Corso { MateriaStudenteID =4, MateriaID = 1, StudenteID = 1005 }
            };

            var Esami = new List<Esame>
            {
                new Esame { StudenteVotoID =1, StudenteID = 1001, VotoID = 1 },
                new Esame { StudenteVotoID =2, StudenteID = 1003, VotoID = 2 },
                new Esame { StudenteVotoID =3, StudenteID = 1005, VotoID = 3 }
            };


            #region QUERY
            var result = (from m in Materie // 'm' l'iteratore per ogni elemento della tabella  'materie'
                          join ms in Corsi // 'ms' l'iteratore per ogni elemento della tabella  'Corsi'
                          on m.MateriaID // elemento di confronto tra le due tabelle 
                          equals ms.MateriaID  // ms è la tabella di Join creata anonimamente
                          into MaterieStudentiJoin 
                          select new   // tabella prodotto della prima  query
                          {
                              MateriaID = m.MateriaID,
                              Studenti = from msJoin in MaterieStudentiJoin // 'msJoin' l'iteratore per ogni elemento della tabella  di Join  'MaterieStudentiJoin' della prima  query
                                         join sVoto in Esami // 'sVoto' l'iteratore per ogni elemento della tabella  'studentiVoto'
                                         on msJoin.StudenteID  //  elemento di confronto tra le due  tabelle
                                         equals sVoto.StudenteID // Condizione di confronto 

                                         select new { 
                                             StudenteId = msJoin.StudenteID,
                                             VotoId = sVoto.VotoID 
                                         } // tabella prodotto della 'seconda' query  con la 'prima' 
                          })
               .ToList();
            #endregion

            foreach (var materia in result)
            {
                Console.WriteLine("Materia: {0}", materia.MateriaID);
                foreach (var studente in materia.Studenti)
                {
                    Console.WriteLine("Studente: {0}", studente.StudenteId);
                          Console.WriteLine("\tVoto: {0}", studente.VotoId);
                }
                Console.WriteLine();
            }


            // OUTPUT: 

            //Materia: 1
            //    Studente: 1001
            //       Voto: 1
            //    Student: 1005
            //        Voto: 3

            //Materia: 2

            //Materia: 3
            //     Studente: 1003
            //         Voto: 2
        }
    }

    public class Materia
    {
        public int MateriaID { get; set; }
        public string Nome { get; set; }
    }

    public class Corso
    {
        public int MateriaStudenteID { get; set; }
        public int MateriaID { get; set; }
        public int StudenteID { get; set; }
    }

    public class Esame
    {
        public int StudenteVotoID { get; set; }
        public int StudenteID { get; set; }
        public int VotoID { get; set; }
    }
}
