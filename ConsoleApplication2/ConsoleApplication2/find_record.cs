using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication2
{
    public struct Record
    {
        public int ClientID;
        public int Years;
        public int Month;
        public int Duration;

        public Record(int ClientID, int Years, int Month, int Duration)
        {
            this.ClientID = ClientID;
            this.Years = Years;
            this.Month = Month;
            this.Duration = Duration;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("{{{0}, {1}, {2}, {3}}}", ClientID, Years, Month, Duration);
        }

        static void PrintMinimumDuration(int year, List<Record> db)
        {
            IEnumerable <Record> persoQuery =
            from perso in Record
            //where ( perso.Duration > 0 )
            orderby perso.Duration ascending
            select perso;
            foreach ( Record perso in persoQuery )
            {
                Console.WriteLine("{{{0}, {1}, {2}, {3}}}", perso.ClientID, perso.Years, perso.Month, perso.Duration);
            }
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Record Felicia = new Record(01, 2020, 04, 2);
            Felicia.DisplayInfo();
 
            Record Job = new Record(03, 2020, 05, 3);
            Job.DisplayInfo();
             
            Console.ReadKey();
        }
    }
}
