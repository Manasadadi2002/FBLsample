using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FBLmannagement.Models
{
    public class AddResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int MatchID { get; set; }
        public String Teamname1 { get; set; }
        public  String Teamname2 { get; set; }
        public String StatusTeam { get; set; }
        public String WinningTeam { get; set; }


    }
}