using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsLesson
{
    public class DataStore<T> where T : class, new()
    {
        static int index = 4;
        T[] _data = new T[index];
        static T entry = new T(); 

        public DataStore()
        {

        }
        public void AddItem(T item)
        {
            
            if (_data[_data.Length -1] != null)
            {
                GetMoreSpace();
            }
            var element = Array.IndexOf(_data, Array.Find(_data, x => x == null));
            _data[element] = item;
            
        } 
        private void GetMoreSpace()
        {
            T[] _nextData = new T[_data.Length + 4]; 
            Array.Copy(_data,_nextData, _data.Length);// + 4 [_data]
            _data = _nextData;  
        }
        public static void Print()
        {
            var campi = entry.GetType().GetProperties();

            foreach (var item in campi)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void ShowAllM()
        {
           
            var tm = typeof(Person);
            foreach (var mi in tm.GetMethods())
            {
                Console.WriteLine(mi.Name); ;
                foreach (var p in mi.GetParameters())
                {
                    Console.WriteLine($"\t{p.ParameterType.Name}");
                }
            }
        }

    } 


    public static class GenericTextFileLogger
    {
        public static void saveToFile<T>(List<T> data, string filePath) where T : class
        {
            List<string> lines = new List<string>(); // 
            StringBuilder line = new StringBuilder(); 

            if(data == null || data.Count == 0)
            {
                throw new ArgumentException("data", "La lista è vuota!"); 
            }

            var cols = data[0].GetType().GetProperties();

            foreach (var col in cols)// cicla tutte le Entity della classe in oggetto
            {
                line.Append(col.Name);
                line.Append(",");
            }

            lines.Add(line.ToString().Substring(0, line.Length - 1));

            foreach (var row in data)
            {   

                line = new StringBuilder();
                foreach (var col in cols)// cicla tutte le Entity della classe in oggetto
                {
                    line.Append(col.GetValue(row));
                    line.Append(","); 
                }
              lines.Add(line.ToString().Substring(0, line.Length - 1));
            }

            System.IO.File.WriteAllLines(filePath, lines);

        }
        public static List<T> LoadFromTextFile<T>(string filePath) where T : class, new()
        {
            List<T> output = new List<T>(); // Crea una lista nella quale inserirò tutti  gli oggetti di tipo  T che andrò a creare partendo dai dati del CSV

            var lines = System.IO.File.ReadAllLines(filePath).ToList(); // --> Estrago tutte le righe dal file
            T entry = new T(); // Creo un oggetto vuoto del tipo che ho T, che servirà come variabile d'appoggio da popolare con i dati.  
            var cols = entry.GetType().GetProperties();// ->> Estrago i nomi delle proprietà dell'oggetto (rappresenteranno  le colonne). 

            //foreach () // Ciclare tutte le righe del file CSV
            //{
            // entry = new T(); // Creare un nuova istanza dell'oggetto che verrà usato per essere valorizzato (le proprietà) con  i valori della riga 
            // var valoriRiga = splitare  i valori della riga del file separati in modo da create un array          


            // ciclare ogni singola colonna del file csv in modo da poter fare un confronto con le proprietà dell'oggetto entry                        
            // --> Controllare che ci sia un Match tra la colonna ,
            // --> Se c'è il Match, valorizzare quella proprietà dell'oggetto con il valore della [cella] che corrisponde alla [riga/colonna].  
            /// -->  entry.property.SetValue([oggetto], Convert.ChangeType(valoreCella, entry.property.PropertyType));
            /// output.Add(entry);
            // }
            return output;
        }
    }
}
    