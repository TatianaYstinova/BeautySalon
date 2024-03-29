using BeautySalon.BLL;
using BeautySalon.BLL.Models;
using BeautySalon.BLL.Models.InputModels;
using BeautySalon.DAL.IRepositories;
using BeautySalon.DAL.Repositories;

namespace BeautySalon.Console;

using BLL.Clients;
using BeautySalon.BLL.OrdersForClientById;
using BeautySalon.BLL.Models;
using BeautySalon.BLL.OrdersForClientById;
using BeautySalon.DAL.DTO;
using System;
using BeautySalon.BLL.AllShiftsWithFreeIntervalsOnCurrentServiceModel;
using BeautySalon.BLL.IClient;

class Program
{
    static void Main(string[] args)
    {
        #region NotWorks

        // Не пашет

        #endregion

        #region Works DAL

        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // var res =userRepository.GetUserByChatId(1);
        // foreach (var item in res)
        // {
        //     Console.WriteLine(item);
        // }

        // //Работает
        //IUserRepository userRepository4 = new UserRepository();
        //userRepository4.AddUserByChatId(32423, "Janet342", "Жанна Дарк", "8999324556", "jannet@mail.ru", 3, 0, 0, 0);

        // //Работает
        //IUserRepository userRepository2 = new UserRepository();
        //var userRepositories2 = userRepository2.GetClientByNameAndId("Оксана Дмитриевна Кек", 4);
        //foreach (var user in userRepositories2)
        //{
        //    Console.WriteLine($"{user.ClientId} {user.Client}");
        //}

        // //Работает
        //IUserRepository userRepository3 = new UserRepository();
        //var userRepositories3 = userRepository3.GetClientByNameAndPhone("Оксана Дмитриевна Кек", "877566588690");
        //foreach (var user in userRepositories3)
        //{
        //    Console.WriteLine($"{user.Name} {user.Phone}");
        //}

        // //Работает
        //IUserRepository userRepository5 = new UserRepository();
        //var userRepositories5 = userRepository5.GetMasterByNameAndId("Анна Петровна Брек", 2);
        //foreach (var user in userRepositories5)
        //{
        //    Console.WriteLine($"{user.Master} {user.MasterId}");
        //}

        // //Работает
        //IUserRepository userRepository = new UserRepository();
        //var usersRepositories = userRepository.GetMasterByNameAndPhone("Анна Петровна Брек", "8923467127");
        //foreach (var user in usersRepositories)
        //{
        //    Console.WriteLine($"{user.Master}, {user.MasterPhone}");
        //}

        // //Работает
        //IUserRepository userRepository = new UserRepository();
        //var userRepositories = userRepository.GetAllWorkersWithContactsByUserId();
        //foreach (var user in userRepositories)
        //{
        //    Console.WriteLine($"{user.Name}");
        //}

        // //Работает
        //IUserRepository userRepository = new UserRepository();
        //userRepository.AddWorkerByRoleId(2, "Кирилл Модестович Мусоргский", "834734269540", "kbslrbkl@sdfsdf");
        //Console.ReadLine();

        //IUserRepository userRepository = new UserRepository();
        //userRepository.AddWorkerByRoleId(2, "Александр Максимович Климов", "85459004345", "xghj@hzf");
        //Console.ReadLine();

        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // UsersDTO DTO = userRepository.RemoveUserById(5);
        // Console.WriteLine(DTO.IsDeleted);

        // //Работает
        //IShiftsRepository shiftRepository = new ShiftsRepository();
        //var shiftsRepositories = shiftRepository.GetAllShiftsOnToday();
        //foreach (var shift in shiftsRepositories)
        //{
        //    Console.WriteLine();
        //}

        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var shiftsRepositories = shiftsRepository.GetAllShiftsAndEmployeesOnToday();
        // foreach (var shift in shiftsRepositories)
        // {
        //     Console.WriteLine($"{shift.Name}");
        //     foreach (var value in shift.Shifts)
        //     {
        //         Console.WriteLine($"{value.Id}, {value.Title}, {value.StartTime}, {value.EndTime}");
        //     }
        // }

        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // var userRepositories = userRepository.GetFreeMastersAndIntervalsOnToday();
        // foreach (var users in userRepositories)
        // {
        //     Console.WriteLine();
        //     foreach (var value in users.Intervals)
        //     {
        //         Console.WriteLine();
        //     }
        // }

        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var shiftsRepositories = shiftsRepository.GetAllShiftsWithFreeIntervalsOnToday();
        // foreach (var shift in shiftsRepositories)
        // {
        //     Console.WriteLine();
        //     foreach (var value in shift.Intervals)
        //     {
        //         Console.WriteLine();
        //     }
        // }

        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // userRepository.ChangeMasterInShift(7, 3);
        // Console.WriteLine();

        // //Работает
        // IOrderRepository orderRepository = new OrderRepository();
        // var repositories = orderRepository.GetAllOrdersForClient();
        // foreach (var repository in repositories)
        // {
        //     Console.WriteLine($"{repository.Id} {repository.Date} {repository.ClientId} {repository.MasterId}");
        // }

        // //Работает
        // IIntervalsRepository intervalsRepository = new IntervalsRepository();
        // var intervalsRepositories = intervalsRepository.GetAllShiftsWithFreeIntervalsOnCurrentService();
        // foreach (var user in userRepositories)
        // {
        //     Console.WriteLine($"{user.Id} {user.Name} {user.Phone} {user.Mail} {user.Roles}");
        // }
        // Console.WriteLine();

        // //Работает
        //IUserRepository userRepository = new UserRepository();
        //userRepository.RemoveMasterFromShift(2, 1);
        //Console.ReadLine();

        // //Работает
        //IIntervalsRepository intervalsRepository = new IntervalsRepository();
        //var intervalsRepositories = intervalsRepository.GetAllShiftsWithFreeIntervalsOnCurrentService(4);
        //foreach (var interval in intervalsRepositories)
        //{
        //    Console.WriteLine($"");
        //}

        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // var userRepositories = userRepository.GetAllWorkersByRoleId();
        // foreach (var user in userRepositories)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // IIntervalsRepository intervalsRepository = new IntervalsRepository();
        // var  intervals = intervalsRepository.GetAllIntervalsByShiftId(1);
        // foreach (var interval in intervals)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // IIntervalsRepository intervalsRepository = new IntervalsRepository();
        // var  intervals = intervalsRepository.GetAllFreeIntervalsByShiftId(1);
        // foreach (var interval in intervals)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // var services = servicesRepository.GetAllServicesByIdFromCurrentType(1);
        // foreach (var service in services)
        // {
        //     Console.WriteLine();
        // }

        // //Работает. Разбирали на занятии с Максом.
        // IOrderRepository orderRepository = new OrderRepository();
        // var orders = orderRepository.GetOrdersByMasterId(2);
        // foreach (var order in orders)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // ITypesRepository typesRepository = new TypesRepository();
        // var types = typesRepository.GetAllServiceTypes();
        // foreach (var type in types)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // servicesRepository.UpdateServiceTitle(1, "Подравнять кончики");

        // //Работает
        //IUserRepository userRepository = new UserRepository();
        //var users = userRepository.GetMastersShiftsById(2);
        //foreach (var user in users)
        //{
        //    Console.WriteLine();
        //}

        // //Работает
        // IOrderRepository orderRepository = new OrderRepository();
        // var orders = orderRepository.GetAllOrdersOnTodayForMaster();
        // foreach (var user in orders)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        //IIntervalsRepository intervalsRepository = new IntervalsRepository();
        //var intervals = intervalsRepository.GetAllIntervals("2024 - 02 - 02");
        //foreach (var interval in intervals)
        //{
        //    Console.WriteLine();
        //}

        // //Работает
        //IServicesRepository servicesRepository = new ServicesRepository();
        //var services = servicesRepository.GetAllServices();
        //foreach (var service in services)
        //{
        //    Console.WriteLine();
        //}

        // //Работает
        //IServicesRepository servicesRepository = new ServicesRepository();
        //servicesRepository.AddServiceById("Бритьё налысо", 1, "00:45", 500);

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // servicesRepository.UpdateServicePrice(1, 500);

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // servicesRepository.UpdateServiceDuration(6, "00:30");

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // servicesRepository.RemoveServiceById(6);
        // Console.ReadLine();

        // //Работает
        // IOrderRepository orderRepository = new OrderRepository();
        // var orders = orderRepository.GetAllOrdersOnToday();
        // foreach (var user in orders)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // IOrderRepository orderRepository = new OrderRepository();
        // orderRepository.AddClientToFreeMaster(2, 1, 2, 30);

        // //Работает
        // IUserRepository repository = new UserRepository();
        // var result = repository.CheckAndAddUser(1);
        // Console.WriteLine(result.ToList());       

        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var result = shiftsRepository.AddMasterToShiftWithCreatedNewIntervals(2, 3);
        // Console.WriteLine(result.ToList());

        // //Работает
        // IIntervalsRepository intervalsRepository = new IntervalsRepository();
        // GetFreeMasterIdByIntervalIdDTO model = new GetFreeMasterIdByIntervalIdDTO
        // {
        //     Id = 1
        // };
        // var res = intervalsRepository.GetFreeMasterIdByIntervalId(model);
        // Console.WriteLine();

        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // var res =userRepository.GetWorkerNameByPassword("12345");
        // foreach (var item in res)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine();
        
        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var shifts = shiftsRepository.GetMastersFromShiftByShiftTitle("УТРО (10:00 - 13:45)");
        // foreach (var master in shifts)
        // {
        //     Console.WriteLine();
        // }

        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // shiftsRepository.RemoveMasterFromShiftByShiftTitle(2, "УТРО (10:00 - 13:45)");
        // Console.ReadLine();
        
        // //Работает
        // IUserRepository userRepository = new UserRepository();
        // var res = userRepository.GetWorkerNameAndChatIdAndIdByPassword("12345");
        // Console.ReadLine();
        
        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var shifts = shiftsRepository.GetMastersAbsentedInSelectedShift("УТРО (10:00 - 13:45)");
        // foreach (var master in shifts)
        // {
        //     Console.WriteLine();
        // }

        #endregion

        #region Works Bll

        // //Работает
        // IntervalsClient intervalsClient = new IntervalsClient();
        // var q = intervalsClient.GetAllFreeIntervalsInCurrentShiftOnCurrentService(1, 2);
        // Console.ReadLine();

        // //Работает
        // IntervalsClient intervalsClient = new IntervalsClient();
        // var q = intervalsClient.GetAllIntervals("2024-02-02");
        // Console.ReadLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // var q = userClient.GetAllWorkersByRoleId();
        // Console.ReadLine();   

        // //Работает
        // UserIdInputModel model = new UserIdInputModel
        // {
        //     Id = 3
        // };
        // UserClient userClient = new UserClient();
        // var q = userClient.RemoveUserById(model);
        // Console.ReadLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // var q = userClient.GetClientByNameAndId("Анна Петровна Брек",2);
        // Console.ReadLine();

        // //Работает
        // UserClient client = new UserClient();
        // AddUserByChatIdInputModel model = new AddUserByChatIdInputModel
        // {
        //     ChatId = 1234323,
        //     UserName = "432KKK",
        //     Name = "Лера Павловна ",
        //     Phone = "854356654645",
        //     Mail = "ffdggfddg@fdgfgfd",
        //     RoleId = 3,
        //     Salary = 0,
        //     IsBlocked = 0,
        //     IsDeleted = 0
        // };
        // client.AddUserByChatId(model);

        // //Работает
        // UserClient userClient = new UserClient();
        // var q = userClient.GetClientByNameAndPhone("Кристина Валерьевна Заливняк","642894209");
        // Console.ReadLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // var q = userClient.GetMasterByNameAndId("Анна Петровна Брек",2);
        // Console.ReadLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // var q = userClient.GetMasterByNameAndPhone("Анна Петровна Брек","8923467127");
        // Console.ReadLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // var q = userClient.GetAllWorkersWithContactsByUserId();
        // Console.ReadLine();  

        // //Работает
        // ShiftsClient shiftsClient = new ShiftsClient();
        // var q = shiftsClient.GetAllShiftsOnToday();
        // Console.ReadLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // WorkerByRoleIdInputModel model = new WorkerByRoleIdInputModel
        // {
        //     RoleId = 2,
        //     Name = "Иваска Петровна Шнюк",
        //     Mail = "23уцкапв@gmail.com",
        //     Phone = "232424356"
        // };
        // userClient.AddWorkerByRoleId(model);
        // Console.ReadLine();

        // //Работает
        // ShiftsClient shiftsClient = new ShiftsClient();
        // var res = shiftsClient.GetAllShiftsAndEmployeesOnToday();
        // Console.WriteLine();

        // //Работает
        // ShiftsClient shiftsClient = new ShiftsClient();
        // var res = shiftsClient.GetAllShiftsAndEmployeesOnToday();
        // Console.WriteLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // var res = userClient.GetAllChatId();
        // Console.WriteLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // userClient.RemoveMasterFromShift(2,1);
        // Console.WriteLine();

        // //Работает
        // IntervalsClient intervals = new IntervalsClient();
        // var res = intervals.GetAllIntervalsByShiftId(1);
        // Console.WriteLine();

        // //Работает
        // UserClient userClient = new UserClient();
        // userClient.ChangeMasterInShift(7,1);
        // Console.WriteLine();

        // //Работает
        // ShiftIdInputModel model = new ShiftIdInputModel
        // {
        //     Id = 2
        // };
        // IntervalsClient intervalsClient = new IntervalsClient();
        // var q = intervalsClient.GetAllFreeIntervalsByShiftId(model);
        // Console.ReadLine();

        // //Работает
        // ShiftsClient shiftsClient = new ShiftsClient();
        // var q = shiftsClient.GetAllShiftsWithFreeIntervalsOnToday();
        // Console.ReadLine();

        // //Работает
        // ServiceClient serviceClient = new ServiceClient();
        // ServiceByIdInputModel model = new ServiceByIdInputModel
        // {
        //     Duration = "60",
        //     Price = 800,
        //     Title = "Стрижка кислотой",
        //     Type = 1
        // };
        // serviceClient.AddServiceByIdInputModel(model);
        // Console.WriteLine();

        // //Работает
        // ShiftsClient shiftsClient = new ShiftsClient();
        // shiftsClient.AddMasterToShiftWithCreatedNewIntervals(2, 7);
        // Console.WriteLine();

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // ServiceIdAndServiceTitleInputModel model = new ServiceIdAndServiceTitleInputModel
        // {
        //     Id = 1,
        //     Title = "Стрижка бензопилой"
        // };
        // IServiceClient serviceClient = new ServiceClient();
        // serviceClient.UpdateServiceTitle(model);
        // Console.WriteLine();

        // //Работает
        // IUserClient userClient = new UserClient();
        // var res = userClient.GetUserByChatId(1);
        // foreach (var item in res)
        // {
        //     Console.WriteLine(res);
        // }

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // ServiceIdAndServicePriceInputModel model = new ServiceIdAndServicePriceInputModel
        // {
        //     Id = 1,
        //     Price = 0
        // };
        // IServiceClient serviceClient = new ServiceClient();
        // serviceClient.UpdateServicePrice(model);
        // Console.WriteLine();

        // //Работает
        // IServicesRepository servicesRepository = new ServicesRepository();
        // ServiceIdAndServiceDurationInputModel model = new ServiceIdAndServiceDurationInputModel
        // {
        //     Id = 1,
        //     Duration = "00:15"
        // };
        // IServiceClient serviceClient = new ServiceClient();
        // serviceClient.UpdateServiceDuration(model);
        // Console.WriteLine();

        // //Работает
        // ServiceIdInputModel model = new ServiceIdInputModel
        // {
        //     Id = 1
        // };
        // ServiceClient serviceClient = new ServiceClient();
        // var q = serviceClient.RemoveServiceById(model);
        // Console.ReadLine();

        // //Работает
        // IntervalsClient intervals = new IntervalsClient();
        // IntervalIdInputModel model = new IntervalIdInputModel
        // {
        //     Id = 1
        // };
        // var res = intervals.GetFreeMasterIdByIntervalId(model);
        // Console.WriteLine();

        // //Работает
        // IUserClient userClient = new UserClient();
        // var res = userClient.GetWorkerNameByPassword("12345");
        // foreach (var item in res)
        // {
        //     Console.WriteLine(res);
        // }
                
        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var shifts = shiftsRepository.GetMastersFromShiftByShiftTitle("УТРО (10:00 - 13:45)");
        // foreach (var master in shifts)
        // {
        //     Console.WriteLine();
        // }                

        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // shiftsRepository.RemoveMasterFromShiftByShiftTitle(7, "УТРО (10:00 - 13:45)");
        // Console.ReadLine();
        
        // //Работает
        // IUserClient userClient = new UserClient();
        // var user = userClient.GetWorkerNameAndChatIdAndIdByPassword("12345");
        // Console.ReadLine();
        
        // //Работает
        // IShiftsRepository shiftsRepository = new ShiftsRepository();
        // var shifts = shiftsRepository.GetMastersAbsentedInSelectedShift("УТРО (10:00 - 13:45)");
        // foreach (var master in shifts)
        // {
        //     Console.WriteLine();
        // }

        #endregion
    }
}