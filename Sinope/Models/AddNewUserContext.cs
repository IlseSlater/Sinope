using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Sinope.Models
{
    [Table("IMS_Login")]
    public class AddNewUserContext : DbContext
    {
        [Key]
        public DbSet<AddNewUser> IMS_Login { get; set; }
    }
}