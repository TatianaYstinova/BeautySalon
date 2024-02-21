namespace BeautySalon.DAL.StoredProcedures;

public class Procedures
{
    public const string GetServiceType = "GetServiceType";
    public const string GetServicesWithPriceAndDurationByTypeId = "GetServicesWithPriceAndDurationByTypeId";
    public const string GetAllRolesProcedure = "GetAllRolesProcedure";
    public const string AddUserByChatId = "AddUserByChatId";
    public const string GetClientByNameAndId = "GetClientByNameAndId";
    public const string GetClientByNameAndPhone = "GetClientByNameAndPhone";
    public const string GetMasterByNameAndId = "GetMasterByNameAndId";
    public const string GetMasterByNameAndPhone = "GetMasterByNameAndPhone";
    public const string GetAllWorkersByRoleId = "GetAllWorkersByRoleId";
    public const string GetAllWorkersWithContactsByUserId = "GetAllWorkersWithContactsByUserId";
    public const string AddWorkerByRoleId = "AddWorkerByRoleId";
    public const string RemoveUserById = "RemoveUserById";
    public const string GetAllShiftsOnToday = "GetAllShiftsOnToday";
    public const string GetAllShiftsAndEmployeesOnToday = "GetAllShiftsAndEmployeesOnToday";
    public const string ChangeMasterInShift = "ChangeMasterInShift";
    public const string RemoveMasterFromShift = "RemoveMasterFromShift";
    public const string GetFreeMastersAndIntervalsOnToday = "GetFreeMastersAndIntervalsOnToday";
    public const string GetAllShiftsWithFreeIntervalsOnToday = "GetAllShiftsWithFreeIntervalsOnToday";
    public const string GetAllIntervalsByShiftId = "GetAllIntervalsByShiftId";
    public const string GetAllFreeIntervalsByShiftId = "GetAllFreeIntervalsByShiftId";
    public const string GetAllServicesByIdFromCurrentType = "GetAllServicesByIdFromCurrentType";
    public const string GetOrdersByMasterId = "GetOrdersByMasterId";
    public const string GetAllServiceTypes = "GetAllServiceTypes";
    public const string UpdateServiceTitle = "UpdateServiceTitle";
    public const string GetMastersShiftsById = "GetMastersShiftsById";
    public const string GetAllOrdersOnTodayForMasters = "GetAllOrdersOnTodayForMasters";
    public const string RemoveOrderForClientByOrderId = "RemoveOrderForClientByOrderId";
    public const string GetAllIntervals = "GetAllIntervals";
    public const string GetAllServices = "GetAllServices";
    public const string AddServiceById = "AddServiceById";
    public const string UpdateServicePrice = "UpdateServicePrice";
    public const string UpdateServiceDuration = "UpdateServiceDuration";
    public const string RemoveServiceById = "RemoveServiceById";
    public const string AddClientToFreeMaster = "AddClientToFreeMaster";
    public const string GetAllOrdersOnToday = "GetAllOrdersOnToday"; 
    public const string GetAllChatId = "GetAllUsersChatId";
    public const string GetOrdersByClientId2 = "GetOrdersByClientId2";
    public const string UpdateOrderTimeForClientById = "UpdateOrderTimeForClientById";
    public const string CreateNewOrder = "CreateNewOrder";
    public const string GetOrderInfo = "GetOrderInfo";
    public const string GetAllFreeIntervalsOnCurrentService = "GetAllFreeIntervalsOnCurrentService";
    public const string GetAllShiftsWithFreeIntervalsOnCurrentService = "GetAllShiftsWithFreeIntervalsOnCurrentService";
    public const string GetAllFreeIntervalsInCurrentShiftOnCurrentService = "GetAllFreeIntervalsInCurrentShiftOnCurrentService";
    public const string CheckAndAddUser = "CheckAndAddUser";
    public const string AddMasterToShiftWithCreatedNewIntervals = "AddMasterToShiftWithCreatedNewIntervals";
    public const string GetFreeMasterIdByIntervalId = "GetFreeMasterIdByIntervalId";
    public const string GetWorkerNameByPassword = "GetWorkerNameByPassword";
}