using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLesson
{
    public class DataStore<T> where T : class, new()
    {
        static int index = 4;
        T[] _data = new T[index];
        T entry = new T(); 

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
        public void Print()
        {
            var campi = entry.GetType().GetProperties();

            foreach (var item in campi)
            {
                Console.WriteLine(item.Name);
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
    }
}
    