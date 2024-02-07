using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.DAL.DTO
{
    public class OrdersByClientIdDTO
    {
        public UsersDTO Master { get; set; }
        public int OrdersId { get; set; }
        public DateTime Date {  get; set; }
        public int StartIntervalId {  get; set; }
        public int ServicesId { get; set; }
        public ServicesDTO Services { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
       

    }
}
