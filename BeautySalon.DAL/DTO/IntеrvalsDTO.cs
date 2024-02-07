namespace BeautySalon.DAL.DTO
{
    public class IntеrvalsDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int ShiftId { get; set; }

        public string StartTime { get; set; }

        public bool? IsBusy { get; set; }
       
        public bool? IsDeleted { get; set; }
    }
}