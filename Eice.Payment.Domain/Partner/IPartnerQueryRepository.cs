﻿using System.Threading.Tasks;

namespace Eice.Payment.Domain.Partner
{
    public interface IPartnerQueryRepository : IQueryRepository<PartnerEntity>
    {
        Task<PartnerEntity> GetByAuthenticationKey(string authenticationKey);
    }
}
