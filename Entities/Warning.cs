using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOOSI.Entities
{
    public class Warning : AdministrativeAction
    {
        public DateTime Expiry { get; set; }

        public Warning() { }

        public Warning(ulong issuerId, ulong victimId, DateTime timeIssued, string reason, DateTime expiry)
            : base(issuerId, victimId, timeIssued, reason)
        {
            Expiry = expiry;
        }
    }
}
