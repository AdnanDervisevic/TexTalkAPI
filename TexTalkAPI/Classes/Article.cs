using System;
using System.Runtime.Serialization;

namespace TexTalkAPI.Classes
{
    public class Article
    {
        [DataMember]
        public string HeaderText { get; set; }

        [DataMember]
        public string IngressText { get; set; }

        [DataMember]
        public string BodyText { get; set; }

        [DataMember]
        public string ImagePath { get; set; }

        [DataMember]
        public int DisplayIndex { get; set; }
    }
}