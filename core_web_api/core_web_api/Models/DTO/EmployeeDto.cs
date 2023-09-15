namespace core_web_api.Models.DTO
{
    public class EmployeeDto
    {
        public Guid ID { get; set; }
        public string emp_name { get; set; }
        public string emp_mail_id { get; set; }
        public string emp_ph_no { get; set; }
        public DateTime created_time { get; set; }
    }
}
