using System.ComponentModel.DataAnnotations;

namespace Grades
{
    public class Credit
    {

        public Credit() 
        {
            Created = DateTime.Now;
        }
        public int Id {  get; set; }
        public DateTime Created { get; set; }
        [Range(1, 5, ErrorMessage ="Value must be between 1 and 5")]
        public int Value { get; set; }
        public bool Success {  get; set; }
    }
}
