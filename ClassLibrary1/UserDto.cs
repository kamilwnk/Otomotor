using System;

namespace Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public bool IsActivated { get; set; }
    }
}
