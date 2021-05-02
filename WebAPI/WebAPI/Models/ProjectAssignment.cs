using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ProjectAssignment
    {
        [Key]
        public int person_id { get; set; }
        [Key]
        public int project_id { get; set; }

        [ForeignKey("person_id")]
        public Person Person { get; set; }
        [ForeignKey("project_id")]
        public Project Project { get; set; }

    }

}
