using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOOSI.Entities
{
    public class Ban : AdministrativeAction
    {
        public int BanLength { get; set; }

        public Ban() { }

        public Ban (ulong issuerId, ulong victimId, DateTime timeIssued, string reason, int banLength)
            : base(issuerId, victimId, timeIssued, reason)
        {
            BanLength = banLength;
        }
    }
}
