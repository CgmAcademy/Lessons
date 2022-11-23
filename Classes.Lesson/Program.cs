using System;
using Class.Lesson.Code;
using Classes.Lesson.Code;

namespace Classes.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            

        } 

        public abstract class FiguraGeomertrica
        {
            FiguraGeomertrica figuraGeomertrica; 
            public abstract void getArea();  
            public FiguraGeomertrica(string figuraGeomertrica) { }
        }
        public  class Cerchio : FiguraGeomertrica
        {
            public override void getArea() { } 

            public Cerchio(String Nome) : base(Nome)
            { 
            }
        }
    }    
}
