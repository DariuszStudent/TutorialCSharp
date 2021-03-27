using System;

namespace Enummm
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------ANIMATION DIRECTION ENUM
            var animationDirection = default(AnimationDirection);

            animationDirection = AnimationDirection.Right;

            var enumString = animationDirection.ToString();                                // zamieniamy Enum na string

            var enumFromString = Enum.Parse(typeof(AnimationDirection), enumString);       // zamieniamy string na Enum

            Animate(animationDirection);

            Console.WriteLine(enumString);
            Console.WriteLine(enumFromString);

            foreach (var enumValue in Enum.GetValues(typeof(AnimationDirection)))           // wyświetlamy wszystkie Enumy
            {
                Console.WriteLine(enumValue);
            }

            // -------------------------------------------------------------------------USER PERMISSIONS
            var userPermissions = UserPermissions.Create | UserPermissions.Delete;

            if ((userPermissions & UserPermissions.Create) == UserPermissions.Create)
            {

            }
            
        }

        public static void Animate(AnimationDirection animationDirection)
        {
            Console.WriteLine($"Animuje teraz obrazek z {animationDirection.ToString()}");
        }
    }
}
