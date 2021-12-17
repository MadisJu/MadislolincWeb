namespace MadislolincWeb.Data
{
    public class Employee
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        private String _imageName = "Default.png";
        public String ImageName { get { return _imageName; } set { _imageName = value; } }
    }
}
