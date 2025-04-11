using GTechAssignment.Data;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static GTechAssignment.Data.Types.Type;


namespace GTechAssignment
{
    public partial class PlanMaster : System.Web.UI.Page
    {
        clsPlanMaster objPlan = new clsPlanMaster();
        PlanMasterInfo ObjPlanInfo = new PlanMasterInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            
            ObjPlanInfo.PlanName = txtName.Value;
            ObjPlanInfo.Tenure = txtTenure.Value != "" ?  Convert.ToInt32(txtTenure.Value) : 0;
            ObjPlanInfo.ROIPercentage = txtROI.Value != "" ? Convert.ToDecimal(txtROI.Value) : 0;

            int rtnVal =  objPlan.PlanMasterInsert(ObjPlanInfo);

            if (rtnVal>0)
            {
                lblMsg.InnerText = "Data saved successfully!";
            }
        }
    }
}