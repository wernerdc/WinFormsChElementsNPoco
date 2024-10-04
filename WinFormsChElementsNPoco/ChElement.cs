using NPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ColumnAttribute = NPoco.ColumnAttribute;

namespace WinFormsChElementsNPoco
{
    [TableName("element")]          // NPoco annotation: DB table name is different to class name
    [PrimaryKey("Id")]
    internal class ChElement
    {
        public ChElement() { }
        public ChElement(int zustand, int ordnungszahl, string name, string symbol)
        {
            ZustandId = zustand;
            Ordnungszahl = ordnungszahl;
            Name = name;
            Symbol = symbol;
        }
        
        public int Id { get; set; } = 0;
        public int ZustandId { get; set; } = 0;
        public int Ordnungszahl { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        public string Symbol { get; set; } = String.Empty;

        // NPoco annotation: ResultColumn ignonres property on update/insert that isn't represented in the table.
        // The property is filled and mapped by raw SQL-Join query in DBHelper
        [ResultColumn]            
        public string ZustandName { get; set; } = String.Empty;
    }
}
