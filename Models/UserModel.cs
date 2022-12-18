using UserList.Utils;

namespace UserList.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profission { get; set; }
        public string Country { get; set; }
    }
}