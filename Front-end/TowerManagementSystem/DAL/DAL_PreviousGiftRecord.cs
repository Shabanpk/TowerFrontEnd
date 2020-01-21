﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessEntities;

namespace DAL
{
   public class DAL_PreviousGiftRecord
    {
        private long InvestmentPosting = 0L;

        string ConnString = DataAccess.ConnString;

        public void Insert_Record(BE_PreviousGift NewBEObj)
        {
            SqlTransaction sqlTransaction = (SqlTransaction)null;
            try
            {
                string Qry = @"Insert into Trans_PreviousGiftRecord(RecordID,Date,Name,Amount,Description,Created_At,Modify_At,IsActive)
                                Values
                                (@RecordID,@Date,@Name,@Amount,@Description,@Created_At,@Modify_At,@IsActive)";
                SqlConnection sqlConnection = new SqlConnection(this.ConnString);
                SqlCommand command = new SqlCommand(Qry, sqlConnection);
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                command.Transaction = sqlTransaction;
                command.CommandType = CommandType.Text;
                command.CommandText = Qry;
                this.InvestmentPosting = int.Parse(DataAccess.GetMaxNO("RecordID", "Trans_PreviousGiftRecord").ToString());
                NewBEObj.ReocordID = this.InvestmentPosting;
                command.Parameters.AddWithValue("@RecordID", (object)NewBEObj.ReocordID);
                command.Parameters.AddWithValue("@Date", (object)NewBEObj.Date);
                command.Parameters.AddWithValue("@Name", (object)NewBEObj.Name);
                command.Parameters.AddWithValue("@Amount", (object)NewBEObj.Amount);
                command.Parameters.AddWithValue("@Description", (object)NewBEObj.Description);
                command.Parameters.AddWithValue("@Created_At", (object)NewBEObj.Created_At);
                command.Parameters.AddWithValue("@Modify_At", (object)"1900-01-01");
                command.Parameters.AddWithValue("@IsActive", NewBEObj.IsActive);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                sqlTransaction.Commit();
                sqlConnection.Close();
                command.Dispose();
                sqlTransaction.Dispose();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, DataAccess.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                sqlTransaction.Rollback();
            }
        }

        public void Update_Record(BE_PreviousGift NewBEObj)
        {
            SqlTransaction sqlTransaction = (SqlTransaction)null;
            try
            {
                string Qry = @"Update Trans_PreviousGiftRecord
                                set
                                Date=@Date,
                                Name=@Name,
                                Amount=@Amount,
                                Description=@Description,
                                Modify_At=@Modify_At,
                                IsActive=@IsActive
                                where RecordID=@RecordID";
                SqlConnection sqlConnection = new SqlConnection(this.ConnString);
                SqlCommand command = new SqlCommand(Qry, sqlConnection);
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                command.Transaction = sqlTransaction;
                command.CommandType = CommandType.Text;
                command.CommandText = Qry;
                command.Parameters.AddWithValue("@RecordID", (object)NewBEObj.ReocordID);
                command.Parameters.AddWithValue("@Date", (object)NewBEObj.Date);
                command.Parameters.AddWithValue("@Name", (object)NewBEObj.Name);
                command.Parameters.AddWithValue("@Amount", (object)NewBEObj.Amount);
                command.Parameters.AddWithValue("@Description", (object)NewBEObj.Description);
                command.Parameters.AddWithValue("@Modify_At", (object)NewBEObj.Modify_At);
                command.Parameters.AddWithValue("@IsActive", NewBEObj.IsActive);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                sqlTransaction.Commit();
                sqlConnection.Close();
                command.Dispose();
                sqlTransaction.Dispose();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, DataAccess.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                sqlTransaction.Rollback();
            }
        }

        public DataTable GetExpenseDetails(long RecordID)
        {
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(this.ConnString);
                string Qry = @"Select * from Trans_PreviousGiftRecord where RecordID='" + RecordID + "'";
                SqlCommand sqlcomm = new SqlCommand(Qry, sqlConnection);
                dataTable2 = DataAccess.GetDataTableByQry(Qry);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, DataAccess.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return dataTable1 = (DataTable)null;
            }
            return dataTable2;
        }

    }
}
