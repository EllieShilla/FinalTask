using FinalTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskTest
{
    internal class SpecializeDtoList
    {
        public static List<SpecializeDto> GetSpecializeDTOLists()
        {
            return new List<SpecializeDto>()
            {
                new SpecializeDto()
                {
                     Count=2,
                     Specialization="фельдшер",
                     Title="Криворізький медичний коледж"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="фельдшер на морських і річкових суднах",
                     Title="Криворізький медичний коледж"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="акушерка",
                     Title="Криворізький медичний коледж"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="медсестра",
                     Title="Криворізький медичний коледж"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="кібербезпека",
                     Title="Київський коледж міського господарства Таврійського національного університету ім. В.І. Вернадського"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="системний аналіз",
                     Title="Київський коледж міського господарства Таврійського національного університету ім. В.І. Вернадського"
                },
                new SpecializeDto()
                {
                     Count=2,
                     Specialization="менеджмент",
                     Title="Київський коледж міського господарства Таврійського національного університету ім. В.І. Вернадського"
                },
                new SpecializeDto()
                {
                     Count=3,
                     Specialization="оператор комп'ютерної техніки",
                     Title="Білгород-Дністровський професійний коледж природокористування, будівництва та комп'ютерних технологій"
                },
                new SpecializeDto()
                {
                     Count=2,
                     Specialization="каменяр",
                     Title="Білгород-Дністровський професійний коледж природокористування, будівництва та комп'ютерних технологій"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="штукатур",
                     Title="Білгород-Дністровський професійний коледж природокористування, будівництва та комп'ютерних технологій"
                },
                new SpecializeDto()
                {
                     Count=1,
                     Specialization="майстер ландшафтного дизайну",
                     Title="Білгород-Дністровський професійний коледж природокористування, будівництва та комп'ютерних технологій"
                }
            };
        }
    }
}
