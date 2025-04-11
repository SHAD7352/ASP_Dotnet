using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static GTechAssignment.Data.Types.Type;
namespace GTechAssignment.Data
{
    public class clsPlanMaster : Base
    {
        public Int32 PlanMasterInsert(PlanMasterInfo d)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "PlanMasterInsert";
            mCmd.CommandType = CommandType.StoredProcedure;

            mCmd.Parameters.AddWithValue("@PlanName", d.PlanName);
            mCmd.Parameters.AddWithValue("@Tenure", d.Tenure);
            mCmd.Parameters.AddWithValue("@ROIPercentage", d.ROIPercentage);

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            Int32 ReturnValue = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnValue = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            
            return ReturnValue;
        }

        public Int32 EmiScheduleInsert(EmiScheduleInfo d)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "EmiScheduleInsert";
            mCmd.CommandType = CommandType.StoredProcedure;

            mCmd.Parameters.AddWithValue("@PlanMasterId", d.PlanMasterId);
            mCmd.Parameters.AddWithValue("@LoanAmount", d.LoanAmount);
            mCmd.Parameters.AddWithValue("@LoanDate", d.LoanDate);
            mCmd.Parameters.AddWithValue("@EmiAmount", d.EmiAmount);

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            Int32 ReturnValue = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnValue = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }

            return ReturnValue;
        }

        public DataTable PlanMasterSelectAll()
        {
            DataTable dt = new DataTable();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            try
            {
                mCon.Open();
                mCmd.CommandText = "PlanMasterSelectAll";
                mCmd.CommandType = CommandType.StoredProcedure;
                mCmd.Connection = mCon;
                SqlDataReader reader = mCmd.ExecuteReader();
                dt.Load(reader);

            }
            catch (Exception ex) { throw ex; }
            finally
            {
                mCmd = null;
                mCon.Close();
            }

            return dt;
        }

        public DataTable PlanMasterSelectById(Int32 PlanMasterId)
        {
            DataTable dt = new DataTable();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            try
            {
                mCon.Open();
                mCmd.CommandText = "PlanMasterSelectById";
                mCmd.CommandType = CommandType.StoredProcedure;
                mCmd.Parameters.AddWithValue("@PlanMasterId", PlanMasterId);
                mCmd.Connection = mCon;
                SqlDataReader reader = mCmd.ExecuteReader();
                dt.Load(reader);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
;            return dt;
        }

        public DataTable EmiScheduleSearch(Int32 PlanMasterId, string LoanDate)
        {
            DataTable dt = new DataTable();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.CommandText = "EmiScheduleSearch";
                mCmd.CommandType = CommandType.StoredProcedure;
                mCmd.Parameters.AddWithValue("@PlanMasterId", PlanMasterId);
                mCmd.Parameters.AddWithValue("@LoanDate", LoanDate);

                SqlDataReader reader = mCmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally 
            { 
                mCmd = null;
                mCon.Close();
            }
            
            return dt;
        }

        public DataTable EmiScheduleMonths()
        {
            DataTable dt = new DataTable();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.CommandText = "EmiScheduleMonths";
                mCmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = mCmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }

            return dt;
        }
    }
}
