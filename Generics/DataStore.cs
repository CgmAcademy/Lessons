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
            var lines = System.IO.File.ReadAllLines(filePath).ToList(); 
            List<T> output = new List<T>(); 
            T entry = new T(); 
            var cols = entry.GetType().GetProperties();

          
            if (lines.Count < 2)
            {
                throw new IndexOutOfRangeException("The file was either empty or missing.");
            }

            // Splits the header into one column header per entry
            var headers = lines[0].Split(',');


            lines.RemoveAt(0); // Rimuovi la prima riga che raprensenta il HEADER

            foreach (var row in lines)
            {
                entry = new T();
                var vals = row.Split(',');
                for (var i = 0; i < headers.Length; i++)
                {
                    foreach (var col in cols)// per ogni header ( rapresenta proprità che mi aspetto), 
                    {
                        if (col.Name == headers[i]) // confronto le proprietà dell'oggetto con i headers
                        {   
                            // estrai il valore  dalla riga del file che  si trova nella stessa colonna in cui l'index del header fa riferimento 
                            var valore  =  vals[i];

                            //Converto il valore da stringa al Type della proprietà dell'oggetto entry
                            var ConvertedValue = Convert.ChangeType(valore, col.PropertyType);

                            // Setto il valore convertito  passandolo direttamente  alla proprietà
                            col.SetValue(entry, ConvertedValue);
                        }
                    }
                }

                output.Add(entry);// ->  aggiungi oggetto apenna creato alla lista 
            }

            return output;
        }
    }
}
    