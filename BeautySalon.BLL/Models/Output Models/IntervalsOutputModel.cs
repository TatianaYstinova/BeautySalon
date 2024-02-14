using BeautySalon.DAL.DTO;

namespace BeautySalon.BLL.Models;

public class IntervalsOutputModel
{
    public List<ShiftsInputModel> Shifts { get; set; }
    
    public int? Id { get; set; }

    public string? Title { get; set; }


    public DateTime? StartTime { get; set; }

    public bool? IsBusy { get; set; }

    public bool? IsDeleted { get; set; }
}