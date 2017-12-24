using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax_Get_Load.Models
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Aile> Aile { get; set; }
        //public Aile Aile { get; set; }
    }

    
}