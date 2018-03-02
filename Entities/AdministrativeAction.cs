using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOOSI.Entities
{
    public class AdministrativeAction
    {
        public ulong IssuerId { get; set; }
        public ulong VictimId { get; set; }
        public DateTime TimeIssued { get; set; }
        public string Reason { get; set; }

        public AdministrativeAction() { }

        public AdministrativeAction(ulong issuerId, ulong victimId, DateTime timeIssued, string reason)
        {
            IssuerId = issuerId;
            VictimId = victimId;
            TimeIssued = timeIssued;
            Reason = reason;
        }
    }
}
