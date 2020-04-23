using System.Collections.Generic;

namespace presentacion.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Response Response { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
