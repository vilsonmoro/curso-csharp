using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public abstract class Informacao
    { 
        public bool ativo { get; set; }
        public int usrInc { get; set; }
        public int usrAlt { get; set; }
        public DateTime datInc { get; set; }
        public DateTime datAlt { get; set; }       
    }
}
