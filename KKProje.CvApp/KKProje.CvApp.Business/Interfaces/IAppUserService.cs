using KKProje.CvApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        /// <summary>
        /// Eğer User var ise true döner yoksa false döner
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);
    }
}
