using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOOSI.Entities
{
    public class Report : AdministrativeAction
    {
        public Report() { }

        public Report(ulong issuerId, ulong victimId, DateTime timeIssued, string reason)
            : base(issuerId, victimId, timeIssued, reason)
        { }
    }
}
