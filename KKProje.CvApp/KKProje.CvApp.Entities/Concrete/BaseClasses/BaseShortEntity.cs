using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Entities.Concrete.BaseClasses
{
    public class BaseShortEntity
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
