using System;
namespace BeautySalon.DAL.DTO;

public class UpdateOrderTimeForClientByIdDto
{
    public int OrderId { get; set; }
    public int ClientId { get; set; }
    public int MasterId { get; set; }
    public int IntervalId { get; set; }
}

