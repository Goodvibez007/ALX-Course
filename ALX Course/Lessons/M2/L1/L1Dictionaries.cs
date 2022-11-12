using ALX_Course.Lessons.M2.L1.ClassesAnEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L1
{
    internal class L1Dictionaries
    {
        public static void Run()
        {
            var fruitDictionary = new Dictionary<int, string>()
            {
                {1, "Banana"},
                {2, "Apple"},
                {3, "Pear"},
                {4, "Strawberry"},
                {5, "Pineapple"},
                {6, "Peach"},
                {7, "Cherry"},
                {8, "Kiwi"},
                {9, "Melon"},
                {0, "Watermelon"},
            };

            Console.WriteLine(fruitDictionary[1]);
            fruitDictionary.Add(10, "Rasberry");
        }

        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name = "ab@domain.com",
                Role = "Administrator"
            };

            var user = MapDTO(userDTO);
            Console.WriteLine($"User: \n\tname:{user.Name}\n\trole:{user.Role}");
        }

        private static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                { "administrator", UserRoles.ADMINISTRATOR},
                { "user", UserRoles.USER},
                { "supervisor", UserRoles.SUPERVISOR},
                { "datacontractor", UserRoles.DATA_CONTRACTOR},
            };

            var roleFromDTO = userDTO.Role
                .ToLower()
                .Replace(" ", "");
            user.Role = mapDictionary[roleFromDTO];

            return user;
        }
    }
}
