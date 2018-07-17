using Dapper;
using MySql.Data.MySqlClient;
using Sino.Dapper;
using Sino.Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    public class ImportRepository : DapperRepositoryBase<Aspnetusers, string>, IImportRepository
    {
        public ImportRepository(IDapperConfiguration configuration) : base(configuration, true)
        {

        }

        public async Task ImportExcel(Queue<DriverVM> listModel)
        {
            try
            {
                if (listModel != null && listModel.Count > 0)
                {
                    //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    //MySqlConnection con = new MySqlConnection("server=192.168.1.208;userid=root;pwd=lyh888150;database=ccp(latest);sslmode=none;");
                    foreach (var item in listModel)
                    {
                        string sql = $"select * from aspnetusers where PhoneNumber={item.PhoneNumber}";
                        var user = new Aspnetusers();
                        using (ReadConnection)
                        {
                            user = await ReadConnection.QueryFirstOrDefaultAsync<Aspnetusers>(sql);

                        }
                        if (user != null)
                        {
                            if (user.UserCategory != UserCategory.JFEmployees)
                            {
                                user.UserCategory = UserCategory.JFEmployees;
                                using (WriteConnection)
                                {
                                    await WriteConnection.UpdateAsync(user);
                                }
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
                            using (WriteConnection)
                            {
                                await WriteConnection.InsertAsync(newuser); ;
                            }
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
