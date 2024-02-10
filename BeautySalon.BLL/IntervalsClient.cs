﻿using AutoMapper;
using BeautySalon.BLL.Mapping;
using BeautySalon.BLL.Models;
using BeautySalon.DAL.DTO;
using BeautySalon.DAL.IRepositories;
using BeautySalon.DAL.Repositories;

namespace BeautySalon.BLL;

public class IntervalsClient
{
    private IntervalsRepository _intervalsRepository;
    private Mapper _mapper;

    public IntervalsClient()
    {
        _intervalsRepository = new IntervalsRepository();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }

    public List<IntеrvalsDTO> GetAllFreeIntervalsInCurrentShiftOnCurrentService(int shiftId, int serviceId)
    {
        List<IntеrvalsDTO> intervals = _intervalsRepository.GetAllShiftsWithFreeIntervalsOnCurrentService(shiftId,serviceId); 
        return _mapper.Map<List<IntеrvalsDTO>>(intervals);
        return intervals;
    }

    public List<IntervalsInputModel> GetAllIntervals(string day)
    {
        List<IntеrvalsDTO> intervals = _intervalsRepository.GetAllIntervals(day);
        return _mapper.Map<List<IntervalsInputModel>>(intervals);

    }
}