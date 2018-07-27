using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly2.Models
{
    public class Customer : DbContext
    {
        public int Id { get; set; }
        public string Name { get; set; }

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