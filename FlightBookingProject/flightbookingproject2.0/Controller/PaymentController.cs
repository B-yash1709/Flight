using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.BusinessLayer.Interface;
using flightbookingproject2._0.DTO;
using Microsoft.AspNetCore.Mvc;

namespace flightbookingproject2._0.Controller
{
    [ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentsController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPost]
    public async Task<IActionResult> MakePayment([FromBody] PaymentDTO dto)
    {
        var payment = await _paymentService.MakePaymentAsync(dto);
        return Ok(payment);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPayment(int id)
    {
        var payment = await _paymentService.GetPaymentDetailsAsync(id);
        if (payment == null) return NotFound();
        return Ok(payment);
    }
}
}