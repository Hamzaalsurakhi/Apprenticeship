using Microsoft.AspNetCore.Identity;

namespace Apprenticeship.Entites
{
    public class Person :IdentityUser
    {
        public string  firstName { get; set; }

        public string secondName { get; set; }

        public string  thirdName { get; set; }

        public string lastName { get; set; }



    }
}
