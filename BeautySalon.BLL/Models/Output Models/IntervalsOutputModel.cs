using BeautySalon.DAL.DTO;

namespace BeautySalon.BLL.Models;

public class IntervalsOutputModel
{
    public int Id { get; set; }

    public string Title { get; set; }

    public List<ShiftsDTO> Shifts { get; set; }

    public DateTime StartTime { get; set; }

    public bool? IsBusy { get; set; }

    //public bool? Busy { get; set; }
         
    public bool? IsDeleted { get; set; }
}