using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    enum TemperaturTypes
    {
        Hot,Cold
    } 
   

    public class Wearing
    {
        public enum WActions
        {
            Puton, Takeoff, leavinghouse
        }
   

        public Wearing(int id,string _action,string name, string hotproperty, string coldproperty, string wtype)
        {
            this.ID = id;
            this.action = _action;
            this.Name = name;
            this.HotProperty = hotproperty;
            this.WType = wtype;
            this.ColdProperty = coldproperty;

        }

       
        public int ID { get; set; }
        public string action { get; set; }
        public string Name { get; set; }
        public string WType { get; set; }
        public string HotProperty { get; set; }
        public string ColdProperty { get; set; }


    }

   


}
