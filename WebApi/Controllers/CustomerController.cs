using AutoMapper;
using CqrsMediatR.Domain;
using CqrsMediatR.Service.Command;
using CqrsMediatR.Service.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;


        public CustomerController(IMediator mediator,IMapper mapper)
        {
            (_mediator, _mapper) = (mediator, mapper);
        }



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("GetAll")]
        public async Task<ActionResult<List<GetAllCustomerResponseDto>>> GetAll()
        {
            try
            {
                var response = await _mediator.Send(new GetAllCustomerQuery());
                return _mapper.Map<List<GetAllCustomerResponseDto>>(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }




        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("CreateCustomer")]
        public async Task<ActionResult<CreateCustomerRequestDto>> Create(CreateCustomerRequestDto createCustomerRequestDto)
        {
            try
            {
                var customer = _mapper.Map<Customer>(createCustomerRequestDto);
                var response = await _mediator.Send(new CreateCustomerCommand() { Customer = customer });
                return _mapper.Map<CreateCustomerRequestDto>(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }






    }
}
