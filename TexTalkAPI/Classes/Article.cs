using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace TexTalkAPI.Classes
{
    public class Article
    {
        [DataMember]
        public string HeaderText { get; set; }

        [DataMember]
        public string IngressText { get; set; }

        [DataMember]
        public IEnumerable<XElement> BodyText { get; set; }

        [DataMember]
        public string ImagePath { get; set; }

        [DataMember]
        public int? DisplayIndex { get; set; }
    }
}