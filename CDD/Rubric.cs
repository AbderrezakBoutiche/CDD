using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessClass
{
    [DataContract]
    public class Rubric
    {
        [DataMember]
        public string NameRubric { get; set; }
        [DataMember]
        public int IDRubric { get; set; }

    }
}
