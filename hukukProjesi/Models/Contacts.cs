//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hukukProjesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string ContactNameSurname { get; set; }
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public Nullable<System.DateTime> ContactDate { get; set; }
        public Nullable<bool> ContactStatus { get; set; }
    }
}
