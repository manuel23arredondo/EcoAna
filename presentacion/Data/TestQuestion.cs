using System.Collections.Generic;

namespace presentacion.Data
{
    public class TestQuestion
    {
        public int Id { get; set; }

        public Question Question { get; set; }
        public ICollection<Response> Responses { get; set; }
        public Test Test { get; set; }
    }
}
