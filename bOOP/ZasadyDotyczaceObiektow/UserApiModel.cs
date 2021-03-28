namespace ZasadyDotyczaceObiektow
{
    public class UserApiModel    // Klasa w której klient korzysta z inf przez API
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsAboveEighteen { get; set; }
    }
}

