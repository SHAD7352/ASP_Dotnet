using GTechAssignment.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static GTechAssignment.Data.Types.Type;

namespace GTechAssignment
{
    public partial class EMISchedule : System.Web.UI.Page
    {
        clsPlanMaster ObjPlan = new clsPlanMaster();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPlanName();
                BindEmiSc();
            }
        }

        protected void BindPlanName()
        {
            DataTable dt = ObjPlan.PlanMasterSelectAll();
            ddlPlanName.DataSource = dt;
            ddlPlanName.DataTextField = "PlanName";
            ddlPlanName.DataValueField = "PlanMasterId";
            ddlPlanName.DataBind();
            ddlPlanName.Items.Insert(0, new ListItem("--Select Paln--", "0"));
        }


        protected void btnCalculateEmi_ServerClick(object sender, EventArgs e)
        {
            decimal loanAmount = Convert.ToDecimal(txtLoanAmount.Value);
            decimal months = Convert.ToDecimal(txtTenure.Value);
            decimal percentage = Convert.ToDecimal(txtROI.Value);

            decimal CalculateEmi = (loanAmount+(loanAmount*(percentage/100)))/months;

            txtEmiAmount.Value = Math.Round(CalculateEmi,2).ToString();
        }

       

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
          
            EmiScheduleInfo objEmiInfo = new EmiScheduleInfo();
            objEmiInfo.PlanMasterId = Convert.ToInt32(ddlPlanName.SelectedValue);
            objEmiInfo.LoanAmount = Convert.ToDecimal(txtLoanAmount.Value);
            objEmiInfo.EmiAmount = Convert.ToDecimal(txtEmiAmount.Value);

            
            int tenure = Convert.ToInt32(txtTenure.Value);
            DateTime loanDate = DateTime.Parse(txtLoanDate.Value); // Convert input date

            for (int i = 1; i <= tenure; i++)
            {
                objEmiInfo.LoanDate = loanDate.ToString("yyyy-MM-dd"); // Store updated date
                ObjPlan.EmiScheduleInsert(objEmiInfo); // Insert EMI schedule

                loanDate = loanDate.AddMonths(1); // Increase by 1 month
            }


        }

        protected void BindEmiSc()
        {
            DataTable dt = ObjPlan.EmiScheduleMonths();
            gdvEmiSchedule.DataSource = dt;
            gdvEmiSchedule.DataBind();
        }


        protected void ddlPlanName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ObjPlan.PlanMasterSelectById(ddlPlanName.SelectedIndex);
            if (dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                txtTenure.Value = dr["Tenure"].ToString();
                txtROI.Value = dr["ROIPercentage"].ToString();
            }
            else
            {
                txtROI.Value = "";
                txtTenure.Value = "";
            }

        }
    }
}