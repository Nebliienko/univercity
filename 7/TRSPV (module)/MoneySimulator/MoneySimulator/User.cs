using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySimulator
{
    public class User
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Income { get; set; }
        public double IncomeMultiplier { get; set; }
        public DateTime Date { get; set; }
        public byte StudyLevel { get; set; }
        public byte WorkLevel { get; set; }
        public byte RealtyLevel { get; set; }
        public byte CoursesLevel { get; set; }
        public byte BussinessLevel { get; set; }

        public User()
        {
            Name = "anonymus";
            IncomeMultiplier = 1;
            Date = new DateTime(2014, 1, 1);
        }
    }
}
