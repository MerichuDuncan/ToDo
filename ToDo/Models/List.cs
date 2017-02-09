using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class List
    {
        //Primary Key
        //Primary Table
        [Key]
        public int ListID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        //Added cause this list would have many tasks
        public virtual ICollection<Task> Tasks { get; set; }


    }

}