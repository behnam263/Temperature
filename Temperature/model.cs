using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
   
    public class Wearing
    {

        /// <summary>
        /// Wearing instance 
        /// </summary>
        /// <param name="id">Id of wearing</param>
        /// <param name="_action">Action to indicate puting on taking off or etc</param>
        /// <param name="name">Name of wearing</param>
        /// <param name="hotproperty">Wearing which appliable for hot weather</param>
        /// <param name="coldproperty">Wearing which appliable for cold weather</param>
        /// <param name="wtype">Type of wearing indicating it is for head food or etc</param>
        public Wearing(int id,string _action,string name, string hotproperty, string coldproperty, string wtype)
        {
            this.ID = id;
            this.action = _action;
            this.Name = name;
            this.HotProperty = hotproperty;
            this.WType = wtype;
            this.ColdProperty = coldproperty;

        }

        /// <summary>
        /// Id of wearing
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Action to indicate puting on taking off or etc
        /// </summary>
        public string action { get; set; }
        /// <summary>
        /// Name of wearing
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type of wearing indicating it is for head food or etc
        /// </summary>
        public string WType { get; set; }
        /// <summary>
        /// Wearing which appliable for hot weather
        /// </summary>
        public string HotProperty { get; set; }
        /// <summary>
        /// Wearing which appliable for cold weather
        /// </summary>
        public string ColdProperty { get; set; }


    }

   


}
