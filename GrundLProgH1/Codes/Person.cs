
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundLProgH1.Codes
{
    internal class Person
    {
        private string? _firstName;

        private string? _lastName;
        public string BirthDateInDanishFormat{ get; set; }
        public int Age { get; set; }
        public double TimeSpanInTotalDays { get; set; }

        public int TelephonNr { get; init; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            TelephonNr = 12345678;
            BirthDateInDanishFormat = birthDate.ToString("dd-MM-yyyy");
            Age = DateTime.Now.Year - birthDate.Year;
            TimeSpan ts = DateTime.Now - birthDate;
            TimeSpanInTotalDays = ts.TotalDays;
        }

        public Person()
        {
            _firstName = "Thomas";
            _lastName = "Jensen";
        }

        public string? GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
