using System.ComponentModel.DataAnnotations;

namespace lab6.Data
{
    public class Orders
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Users UserID { get; set; }
        public Service ServiceID { get; set; }
    }
}
    

