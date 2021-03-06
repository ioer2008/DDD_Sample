﻿using Domain.Leave.Entity.ValueObject;
using Interfaces.WebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.WebAPI.Assembler
{
    public class ApplicantAssembler
    {
        public static ApplicantDTO ToDTO(Applicant applicant)
        {
            var dto = new ApplicantDTO()
            {
                PersonId = applicant.PersonId,
                PersonName = applicant.PersonName,
                ApplicantType = applicant.PersonType.ToString(),


            };
            return dto;
        }

        public static Applicant ToDO(ApplicantDTO dto)
        {
            var applicant = new Applicant()
            {
                PersonId = dto.PersonId,
                PersonName = dto.PersonName
            };
            return applicant;
        }
    }
}
