using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project4.Model
{
    public class TblEmployee
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime Doj { get; set; }

        public string Gender { get; set; }

        public int IsMarried { get; set; }

        public int IsActive { get; set; }

        public int DesignationId{ get; set; }


        [NotMapped]
        public string Designation { get; set; }
    }
}
