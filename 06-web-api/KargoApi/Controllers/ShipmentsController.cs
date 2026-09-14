using Microsoft.AspNetCore.Mvc; 

[ApiController] //Controller sınıfının bir API Controller olduğunu belirtir.
[Route("api/[controller]")] //Controller sınıfının route adresini belirtir. [controller] kısmı controller sınıfının adını alır.
public class ShipmentsController : ControllerBase
{
    //GET /api/shipments/TR998877
    [HttpGet("{trackingNo}")]
    public IActionResult GetByTrackingNo(string trackingNo)
    {
        return Ok(new { TrackingNo = trackingNo, Status = "Yolda", CurrentCity = "Ankara" });
    }
}