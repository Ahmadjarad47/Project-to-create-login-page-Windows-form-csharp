using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
     class Student
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }

        public string? College { get; set; }



        public Student(string Names,string Numebrs,string Colleges)
        {
            Name = Names;
            Number = Numebrs;
            College = Colleges;
        }
    }
}
