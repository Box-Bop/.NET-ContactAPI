using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Models
{
    [DataContract(IsReference = true)]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Value { get; set; }
        

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}