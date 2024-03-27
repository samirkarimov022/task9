
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student samir = new Student("Samir", "Karimov", "AB106", 81);           
            samir.GetInfo();
            samir.Graduate();
            samir.GetDiplomDegree();
        }
        
    }
    class Student
    {
        public string Name;
        public string SureName;
        public string Group;
        public decimal Point;
        public bool IsGraduated;
        public Student(string name, string surname, string group, decimal point)
        {
            this.Name = name;
            this.SureName = surname;
            this.Group = group;
            this.Point = point;
            this.IsGraduated = point >= 65;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{SureName}");
            Console.WriteLine($"{Group}");
            Console.WriteLine($"{Point}");
          
        }
        public void Graduate()
        {
            if (IsGraduated)
            {
                Console.WriteLine("kechib");

            }
            else
            {
                Console.WriteLine("kesilib");
            }
        }
        public void GetDiplomDegree() 
        {
        if(Point < 65) 
            {
                Console.WriteLine("diplom yoxdur");
            }
        else if(Point >= 65 &&  Point <=80)
            {
                Console.WriteLine("adi diplom");

            }
            else if (Point > 80 &&  Point <= 90 )
            {
                Console.WriteLine("sheref diplomu");
            }
        else
            {
                Console.WriteLine("yuksek sheref diplomu");
            }



        }

    }
}
