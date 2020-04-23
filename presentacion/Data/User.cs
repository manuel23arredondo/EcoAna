namespace presentacion.Data
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Client Client { get; set; }
        public Expert Expert { get; set; }
    }
}
