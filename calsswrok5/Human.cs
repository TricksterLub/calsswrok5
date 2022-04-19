using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calsswrok5
{
    internal class Human
    {
        /* public Human()
         {
             Name = "Иван";
             SecondName = "Иванов";
             FullName = "Иван Иванов";
             year = DateTime.Now.Year;
             month = DateTime.Now.Month; 
             day = DateTime.Now.Day;

         }
        */
        private string _name;
        private string _secondName;
        private int _year;
        private int _month;
        private int _day;
        public Human(string name1, string secondname1,  int year1, int month1, int day1)
        {
            Name = name1;
            SecondName = secondname1;
            year = year1;
            month = month1;
            day = day1;
            
        }
        public string Name 
        { 
            get
            {
                return _name;
            } 
            set
            {
                
                if (value == null)
                {
                    _name = "Иван";
                } else
                {
                    _name = value;
                }
            }
            
        }
        
   
        public string SecondName { 
            get
            {
                return _secondName;
            }
            set
            { 
                if (value == null)
                {
                    _secondName = "Иванов";
                } else
                {
                    _secondName = value;
                }
            }
        }
       
        
        public int year
        {
            get
            {
                return _year;
            }


            set
            { 
                if (value < 1900)
                {
                    _year = 1900;
                }
                else if (value > DateTime.Now.Year)
                {
                    _year = DateTime.Now.Year;
                }
                else
                {
                    _year = value;
                }
            }
        }
       
        public int month {
            get
            {
                return _month;
            }


            set
            {
                if (value < 0)
                {
                    _month = 1;
                }
                else if (value > 12)
                {
                    _month = 12;
                }
                else
                {
                    _month = value;
                }
            }
        }
        
        public int day {
            get
            {
                return _day;
            }


            set
            {
                if (value < 0)
                {
                    _day = 1;
                }
                else if (value > 31)
                {
                    _day = 31;
                }
                else
                {
                    _day = value;
                }
            }
        }

        public string FullName 
        {
             get
            {                
                
                return Name + " " + SecondName;
            }
         }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                return now.Year - year -  (now.Month> month || now.Month == month && now.Day>= day ? 0:1);
            }
    }
        
     public void AllInfo()
        {
            Console.Clear();
            Console.WriteLine(FullName);
            Console.WriteLine($"Вам {Age} лет");

        }   
     
    }
}
