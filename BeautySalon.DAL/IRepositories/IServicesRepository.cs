using BeautySalon.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.DAL.IRepositories
{
    public interface IServicesRepository
    {
        public List<ServicesDTO> GetServicesWithPriceAndDurationByTypeId(int typeId);
        public List<GetAllServicesByIdFromCurrentTypeDTO> GetAllServicesByIdFromCurrentType(int id);
        public void UpdateServiceTitle(UpdateServiceTitleDTO dto);
        public List<GetAllServicesDTO> GetAllServices();
        public void AddServiceById(AddServiceByIdDTO model);
        public void UpdateServicePrice(UpdateServicePriceDTO dto);
        public ServicesDTO RemoveServiceById(int id);
        public List<AllFreeIntervalsOnCurrentServiceDTO> GetAllFreeIntervalsOnCurrentService(int serviceId);
        public void UpdateServiceDuration(UpdateServiceDurationDTO dto);
    }
}
