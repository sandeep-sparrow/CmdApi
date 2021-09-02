using System.ComponentModel.DataAnnotations.Schema;

namespace CmdApi.Models{

    [Table("Command")]
    public class Command{

        public int Id { get; set; }
        public string HowTo {get; set;}

        public string Platform{get; set;}

        public string CommandLine {get; set;}
    }
}