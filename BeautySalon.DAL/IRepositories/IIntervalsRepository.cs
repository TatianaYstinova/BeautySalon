using System.Collections.Generic;
using BeautySalon.DAL.DTO;

namespace BeautySalon.DAL.IRepositories;

public interface IIntervalsRepository
{
    public List<GetAllIntervalsByShiftIdDTO> GetAllIntervalsByShiftId(int shiftId);
    public List<GetAllFreeIntervalsByShiftIdDTO> GetAllFreeIntervalsByShiftId(int shiftId);
    public List<IntеrvalsDTO> GetAllIntervals(string day);
    public List<GetAllFreeIntervalsInCurrentShiftOnCurrentServiceDTO> GetAllFreeIntervalsInCurrentShiftOnCurrentService(int serviceId, int shiftId);
}