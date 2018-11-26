using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mc.meeting.Models
{
    public class CompanyAccountBE
    {
        public string accountId { get; set; }
        public DateTime registrationDate { get; set; }
        public string companyName { get; set; }
        public string logo { get; set; }
        public string serviceArea { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string communicationAddress { get; set; }
        public string communicationEmail { get; set; }
        public string communicationPhone { get; set; }
        public string contactPerson { get; set; }
        public string contactPersonDesignation { get; set; }
        public bool accountStatus { get; set; }
    }
}
