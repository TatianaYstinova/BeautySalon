using BeautySalon.DAL.DTO;

namespace BeautySalon.DAL.IRepositories;

public interface IShiftsRepository
{
    public List<GetAllShiftsOnTodayDTO> GetAllShiftsOnToday();
    public List<GetAllShiftsAndEmployeesOnTodayDTO> GetAllShiftsAndEmployeesOnToday();
    public List<GetAllShiftsWithFreeIntervalsOnTodayDTO> GetAllShiftsWithFreeIntervalsOnToday();
    public List<AllShiftsWithFreeIntervalsOnCurrentServiceDTO> GetAllShiftsWithFreeIntervalsOnCurrentService(int serviceId);
}