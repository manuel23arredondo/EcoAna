using System.Collections.Generic;

namespace presentacion.Data
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Expert Expert { get; set; }
        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}
