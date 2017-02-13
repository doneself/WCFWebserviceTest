using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using Entity;

namespace WebService
{
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public List<Student> Students { get; set; }
    }
}