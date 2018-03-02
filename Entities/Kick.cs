using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOOSI.Entities
{
    public class Kick : AdministrativeAction
    {
        public Kick() { }

        public Kick(ulong issuerId, ulong victimId, DateTime timeIssued, string reason)
            : base(issuerId, victimId, timeIssued, reason)
        { }
    }
}
