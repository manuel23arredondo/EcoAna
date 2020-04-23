using System.Collections.Generic;

namespace presentacion.Data
{
    public class Question
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}
