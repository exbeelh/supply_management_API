using Microsoft.AspNetCore.Mvc;
using SuplyManagement.DTOs.CompanyDto;
using SuplyManagement.Services;
using SuplyManagement.Utilities.Handlers;
using System.Net;

namespace SuplyManagement.Controllers
{
    [Route("companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _companyService;

        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _companyService.GetAll();
                if (!result.Any())
                    return NotFound(new ResponseHandler<GetCompanyDto>
                    {
                        Code = StatusCodes.Status404NotFound,
                        Status = HttpStatusCode.NotFound.ToString(),
                        Message = "Data not found"
                    });

                return Ok(new ResponseHandler<IEnumerable<GetCompanyDto>>
                {
                    Code = StatusCodes.Status200OK,
                    Status = HttpStatusCode.OK.ToString(),
                    Message = "Data Found",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseExceptionHandler
                {
                    Code = StatusCodes.Status500InternalServerError,
                    Status = HttpStatusCode.InternalServerError.ToString(),
                    Message = ex.Message
                });
            }
        }
    }
}
