using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessClass
{
    [DataContract]
    public class Topic
    {
        [DataMember]
        public string TitleTopic { get; set; }
        [DataMember]
        public string TextTopic { get; set; }
        [DataMember]
        public DateTime DateTopic { get; set; }
        [DataMember]
        public int IDTopic { get; set; }
        [DataMember]
        public int IDPerson { get; set; }
        [DataMember]
        public int IDRubric { get; set; }
    }
}
