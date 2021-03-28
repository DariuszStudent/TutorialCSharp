using System;

namespace ZasadyDotyczaceObiektow
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapper = new UserMapper();

            var entity = new UserEntity
            {
                Name = "Darek",
                Age = 34,
                Email = "przykładowy@gmail.com",
            };

            /*var dto = new UserDto                 // przepisywanie jest męczącę!!!
            {
                Name = entity.Name,
                Age = entity.Age,
                Email = entity.Email,
                IsAboveEighteen = entity.Age > 18,
            };*/

            var dto = mapper.Map(entity);
        }
    }
}
