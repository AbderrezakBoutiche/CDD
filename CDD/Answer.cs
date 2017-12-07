using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessClass
{
    [DataContract]
    public class Answer
    {

        [DataMember]
        public string TextAnswer { get; set; }
        [DataMember]
        public DateTime DateAnswer { get; set; }
        [DataMember]
        public static int IDAnswer { get; set; }
        [DataMember]
        public int IDTopic { get; set; }
        [DataMember]
        public int IDPerson { get; set; }
        [DataMember]
        public string ID = IDAnswer.ToString();
    }
