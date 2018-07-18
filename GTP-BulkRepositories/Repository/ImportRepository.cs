using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    public class ImportRepository : IImportRepository
    {
        public ImportRepository()
        {
            
        }

        public async Task ImportExcel(Queue<DriverVM> listModel)
        {
            try
            {
                if (listModel != null && listModel.Count > 0)
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    MySqlConnection con = new MySqlConnection("server=192.168.1.208;userid=root;pwd=lyh888150;database=ccp(latest);sslmode=none;");
                    foreach (var item in listModel)
                    {
                        string sql = $"select * from aspnetusers where PhoneNumber={item.PhoneNumber}";
                        var user = await con.QueryFirstOrDefaultAsync<Aspnetusers>(sql);
                        if (user != null)
                        {
                            if (user.UserCategory != UserCategory.JFEmployees)
                            {
                                user.UserCategory = UserCategory.JFEmployees;
                                string sql1 = $"update aspnetusers set UserCategory={user.UserCategory} where Id={user.Id}";
                                await con.ExecuteAsync(sql1);
                            }
                        }
                        else
                        {
                            var newuser = new Aspnetusers()
                            {
                                PhoneNumber = item.PhoneNumber,
                                UserName = item.PhoneNumber,
                                CertificatePhotoCertificationState = CertificationStatus.Uncommitted,
                                DrivingLicenseKeyCertificationState = CertificationStatus.Uncommitted,
                                IdentityCardCertificationState = CertificationStatus.Uncommitted,
                                LockoutEnabled = true,
                                RealNameStatus = CertificationStatus.Uncommitted,
                                CertificationStatus = CertificationStatus.Uncommitted,
                                TrailerLicenseCertificationStatus = CertificationStatus.Uncommitted,
                                VehiclePhotoCertificationStatus = CertificationStatus.Uncommitted,
                                RoleType = ApplicationRoleType.Driver,
                                RoadTransportStatus = CertificationStatus.Uncommitted,
                                Date = DateTime.Now,
                                UserCategory = UserCategory.JFEmployees
                            };
                            DynamicParameters param = new DynamicParameters();
                            string sql2 = @"insert into aspnetusers(Id,PhoneNumber,UserName,CertificatePhotoCertificationState,DrivingLicenseKeyCertificationState,
                                           IdentityCardCertificationState,LockoutEnabled,RealNameStatus,CertificationStatus,TrailerLicenseCertificationStatus,
                                           VehiclePhotoCertificationStatus,RoleType,RoadTransportStatus,Date,UserCategory,Integral)
                                           values(@Id,@PhoneNumber,@UserName,@CertificatePhotoCertificationState,@DrivingLicenseKeyCertificationState,
                                           @IdentityCardCertificationState,@LockoutEnabled,@RealNameStatus,@CertificationStatus,@TrailerLicenseCertificationStatus,
                                           @VehiclePhotoCertificationStatus,@RoleType,@RoadTransportStatus,@Date,@UserCategory,@Integral)";
                            param.Add("@Id", newuser.Id);
                            param.Add("@PhoneNumber", newuser.PhoneNumber);
                            param.Add("@UserName", newuser.UserName);
                            param.Add("@CertificatePhotoCertificationState", newuser.CertificatePhotoCertificationState);
                            param.Add("@DrivingLicenseKeyCertificationState", newuser.DrivingLicenseKeyCertificationState);
                            param.Add("@IdentityCardCertificationState", newuser.IdentityCardCertificationState);
                            param.Add("@LockoutEnabled", newuser.LockoutEnabled);
                            param.Add("@RealNameStatus", newuser.RealNameStatus);
                            param.Add("@CertificationStatus", newuser.CertificationStatus);
                            param.Add("@TrailerLicenseCertificationStatus", newuser.TrailerLicenseCertificationStatus);
                            param.Add("@VehiclePhotoCertificationStatus", newuser.VehiclePhotoCertificationStatus);
                            param.Add("@RoleType", newuser.RoleType);
                            param.Add("@RoadTransportStatus", newuser.RoadTransportStatus);
                            param.Add("@Date", newuser.Date);
                            param.Add("@UserCategory", newuser.UserCategory);
                            param.Add("@Integral", newuser.Integral);
                            await con.ExecuteAsync(sql2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
