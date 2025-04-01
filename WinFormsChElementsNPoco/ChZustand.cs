using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChElementsNPoco
{
    [NPoco.TableName("zustand")]          // NPoco annotation: DB table name is not the same as class name
    [NPoco.PrimaryKey("Id")]
    class ChZustand
    {
        public ChZustand() { }
        
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}
