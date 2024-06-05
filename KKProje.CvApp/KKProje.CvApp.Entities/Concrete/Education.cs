using KKProje.CvApp.Entities.Concrete.BaseClasses;
using KKProje.CvApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Educations")]
    public class Education : BaseEntity, ITable
    {
    }
}
