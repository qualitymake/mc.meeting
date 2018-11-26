using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mc.meeting.Models;
using System.Data;
using System.Data.SqlClient;

namespace mc.meeting.DAL
{
    public class CompanyAccount
    {
        public bool UpdateCompanyAccount(CompanyAccountBE companyAccountBE)
        {
            try
            {
                SqlCommand command = new SqlCommand("usp_UpdateCompanyAccount", SQLConnect.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@accountId", companyAccountBE.accountId);
                command.Parameters.AddWithValue("@registrationDate", companyAccountBE.registrationDate);
                command.Parameters.AddWithValue("@logo", companyAccountBE.logo);
                command.Parameters.AddWithValue("@serviceArea", companyAccountBE.serviceArea);
                command.Parameters.AddWithValue("@country", companyAccountBE.country);
                command.Parameters.AddWithValue("@state", companyAccountBE.state);
                command.Parameters.AddWithValue("@city", companyAccountBE.city);
                command.Parameters.AddWithValue("@communicationAddress", companyAccountBE.communicationAddress);
                command.Parameters.AddWithValue("@communicationEmail", companyAccountBE.communicationEmail);
                command.Parameters.AddWithValue("@communicationPhone", companyAccountBE.communicationPhone);
                command.Parameters.AddWithValue("@contactPerson", companyAccountBE.contactPerson);
                command.Parameters.AddWithValue("@contactPersonDesignation", companyAccountBE.contactPersonDesignation);
                command.Parameters.AddWithValue("@accountStatus", companyAccountBE.accountStatus);

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
