﻿using System.Threading.Tasks;

namespace Tripod.Domain.Security
{
    /// <summary>
    /// Find a LocalMembership by verified EmailAddress.
    /// </summary>
    public class LocalMembershipByVerifiedEmail : BaseEntityQuery<LocalMembership>, IDefineQuery<Task<LocalMembership>>
    {
        /// <summary>
        /// Find a LocalMembership by verified EmailAddress.
        /// </summary>
        /// <param name="emailAddress">Verified email address value to find a LocalMembership for.</param>
        public LocalMembershipByVerifiedEmail(string emailAddress) { EmailAddress = emailAddress; }

        public string EmailAddress { get; private set; }
    }

    [UsedImplicitly]
    public class HandleLocalMembershipByVerifiedEmailQuery : IHandleQuery<LocalMembershipByVerifiedEmail, Task<LocalMembership>>
    {
        private readonly IReadEntities _entities;

        public HandleLocalMembershipByVerifiedEmailQuery(IReadEntities entities)
        {
            _entities = entities;
        }

        public Task<LocalMembership> Handle(LocalMembershipByVerifiedEmail query)
        {
            var queryable = _entities.Query<LocalMembership>().EagerLoad(query.EagerLoad);
            return queryable.ByVerifiedEmailAsync(query.EmailAddress);
        }
    }
}
