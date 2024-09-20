using NPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChElementsNPoco
{
    [TableName("element")]          // DB table name is different from class name
    internal class ChElement
    {
        private static string[] s_zustaende = ["Unbekannt", "Gas", "Feststoff", "Flüssigkeit"];
        public ChElement(int ordnungszahl, string name, string symbol, int zustand)
        {
            Ordnungszahl = ordnungszahl;
            Name = name;
            Symbol = symbol;
            Zustand = zustand;
        }
        public int ID { get; set; } = 0;
        public int Ordnungszahl { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Zustand { get; set; }
        [Ignore]            // ignonres property that isn't represented in the DB
        public string ZustandName 
        { 
            get { return s_zustaende[Zustand]; } 
        }
    }
}
