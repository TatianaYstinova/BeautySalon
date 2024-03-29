﻿
using AutoMapper;
using BeautySalon.BLL.IClient;
using BeautySalon.BLL.Mapping;
using BeautySalon.BLL.Models.Output_Models;
using BeautySalon.DAL.DTO;
using BeautySalon.DAL.IRepositories;
using BeautySalon.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon.BLL.Models;
using BeautySalon.BLL.Models.InputModels;

namespace BeautySalon.BLL.Clients
{
    public class ServiceClient : IServiceClient
    {
        private IServicesRepository _servicesRepository;
        private Mapper _mapper;

        public ServiceClient()
        {
            _servicesRepository = new ServicesRepository();
            IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
            _mapper = new Mapper(config);
        }
        public List<AllServicesByIdFromCurrentTypeOutputModel> GetAllServicesByIdFromCurrentType(int id)
        {
            List<GetAllServicesByIdFromCurrentTypeDTO> getAllServices = this._servicesRepository.GetAllServicesByIdFromCurrentType(id);
            List<AllServicesByIdFromCurrentTypeOutputModel> result = this._mapper.Map<List<AllServicesByIdFromCurrentTypeOutputModel>>(getAllServices);
            return result;
        }
        public List<AllServicesOutputModel> GetAllServices()
        {
            List<GetAllServicesDTO> allServices = this._servicesRepository.GetAllServices();
            List<AllServicesOutputModel> result = this._mapper.Map<List<AllServicesOutputModel>>(allServices);
            return result;
        }

        public void UpdateServiceTitle(ServiceIdAndServiceTitleInputModel model)
        {
            IServicesRepository servicesRepository = new ServicesRepository();
            UpdateServiceTitleDTO newDTO = this._mapper.Map<UpdateServiceTitleDTO>(model);
            servicesRepository.UpdateServiceTitle(newDTO);
        }

        public void UpdateServicePrice(ServiceIdAndServicePriceInputModel model)
        {
            IServicesRepository servicesRepository = new ServicesRepository();
            UpdateServicePriceDTO newDTO = this._mapper.Map<UpdateServicePriceDTO>(model);
            servicesRepository.UpdateServicePrice(newDTO);
        }

        public void UpdateServiceDuration(ServiceIdAndServiceDurationInputModel model)
        {
            IServicesRepository servicesRepository = new ServicesRepository();
            UpdateServiceDurationDTO newDTO = this._mapper.Map<UpdateServiceDurationDTO>(model);
            servicesRepository.UpdateServiceDuration(newDTO);
        }

        public ServiceIsDeletedOutputModel RemoveServiceById(ServiceIdInputModel model)
        {
            IServicesRepository servicesRepository = new ServicesRepository();
            ServicesDTO dto = _servicesRepository.RemoveServiceById(model.Id);
            var result = _mapper.Map<ServiceIsDeletedOutputModel>(dto);
            return result;
        }
        public void AddServiceById(ServiceByIdInputModel model)
        {
            AddServiceByIdDTO dto = _mapper.Map<AddServiceByIdDTO>(model);
            _servicesRepository.AddServiceById(dto);
        }
    }
}
