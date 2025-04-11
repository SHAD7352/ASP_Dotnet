using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTechAssignment.Data.Types
{
    public class Type
    {
        public class PlanMasterInfo
        {
            public int PlanMasterId { get; set; }
            public string PlanName { get; set; }
            public Int32 Tenure { get; set; }
            public decimal ROIPercentage { get; set; }

        }
        public class EmiScheduleInfo
        {
            public Int32 PlanMasterId { get; set; }
            public decimal LoanAmount { get; set; }
            public string LoanDate { get; set; }
            public decimal EmiAmount { get; set; }
        }
    }
}
