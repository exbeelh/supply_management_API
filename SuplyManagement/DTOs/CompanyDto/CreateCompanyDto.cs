using SuplyManagement.Models;

namespace SuplyManagement.DTOs.CompanyDto
{
    public class CreateCompanyDto
    {
        public string CompanyId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string CompanyPhone { get; set; } = null!;
        public string? Photo { get; set; }

        public static implicit operator TbCompany(CreateCompanyDto companyDto)
        {
            return new TbCompany
            {
                CompanyId = Guid.NewGuid().ToString(),
                CompanyName = companyDto.CompanyName,
                Email = companyDto.Email,
                PhoneNumber = companyDto.CompanyPhone,
                Photo = companyDto.Photo,
            };
        }

        public static explicit operator CreateCompanyDto(TbCompany company)
        {
            return new CreateCompanyDto
            {
                CompanyName = company.CompanyName,
                Email = company.Email,
                CompanyPhone = company.PhoneNumber!,
                Photo = company.Photo,
            };
        }
    }
}
