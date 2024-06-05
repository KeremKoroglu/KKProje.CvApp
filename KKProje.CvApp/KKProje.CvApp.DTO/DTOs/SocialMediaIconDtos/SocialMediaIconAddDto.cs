using KKProje.CvApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.DTO.DTOs.SocialMediaIconDtos
{
    public class SocialMediaIconAddDto : IDto
    {
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserID { get; set; }
    }
}
