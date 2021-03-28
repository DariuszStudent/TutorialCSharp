namespace ZasadyDotyczaceObiektow
{
    public class UserDto                 // klasa w której sprawdzane są dane i dawane do bazy danych
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsAboveEighteen { get; set; }
    }
}
