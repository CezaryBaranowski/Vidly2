﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Security;

namespace Vidly2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Min18YearsIfAMember]
        public DateTime? BirthdayDate { get; set; }  

        public Customer()
        {

        }

        public Customer(string name)
        {
            this.Name = name;
        }
        public Customer(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}