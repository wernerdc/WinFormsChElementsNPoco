using NPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChElementsNPoco
{
    [TableName("element")]
    internal class ChElement
    {
        private static string[] s_zustaende = ["Unbekannt", "Gas", "Feststrff", "Flüssigkeit"];
        public ChElement(int ordnungszahl, string name, string symbol, int zustand)
        {
            Ordnungszahl = ordnungszahl;
            Name = name;
            Symbol = symbol;
            Zustand = zustand;
        }
        public int Ordnungszahl { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Zustand { get; set; }
        [Ignore]
        public string ZustandName 
        { 
            get { return s_zustaende[Zustand]; } 
        }
    }
}
