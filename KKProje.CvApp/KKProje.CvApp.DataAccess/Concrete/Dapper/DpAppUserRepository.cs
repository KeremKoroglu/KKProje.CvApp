using Dapper;
using KKProje.CvApp.DataAccess.Interfaces;
using KKProje.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository : DpGenericRepository<AppUser>, IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.Query<AppUser>("SELECT * FROM AppUsers " +
                "WHERE Username = @UserName AND Password = @Password", new 
                { 
                    UserName = userName,
                    Password = password
                });
            return user != null;
        }
    }
}
