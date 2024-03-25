using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary.Models
{
    public class Emberek
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Varos { get; set; }
        public string Szakma { get; set; }
        public string Hobbi { get; set; }

        public Emberek() { }

        public Emberek(string sor)
        {
            var a = sor.Split(";");
            Id = Convert.ToInt32(a[0]);
            Nev = a[1];
            Kor = Convert.ToInt32(a[2]);
            Varos = a[3];
            Szakma = a[4];
            Hobbi = a[5];
        }

        public override string? ToString()
        {
            return $"A nevem {Nev}, {Kor} éves vagyok, {Varos}-ban/ben lakom, a szakmám {Szakma}, a hobbim/hobbijaim {Hobbi}";
        }
    }
}
