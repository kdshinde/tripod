﻿using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Tripod.Domain.Security
{
    public class HashedPassword : IDefineQuery<Task<string>>
    {
        public HashedPassword(string password)
        {
            Password = password;
        }

        public string Password { get; private set; }
    }

    [UsedImplicitly]
    public class HandleHashedPasswordQuery : IHandleQuery<HashedPassword, Task<string>>
    {
        private readonly UserManager<User, int> _userManager;

        public HandleHashedPasswordQuery(UserManager<User, int> userManager)
        {
            _userManager = userManager;
        }

        public Task<string> Handle(HashedPassword query)
        {
            var hashedPassword = _userManager.PasswordHasher.HashPassword(query.Password);
            return Task.FromResult(hashedPassword);
        }
    }
}
