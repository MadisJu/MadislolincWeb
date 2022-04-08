namespace MadislolincWeb.Data
{
    public class News
    {
        public String Title { get; set; }
        private String _imageName = "Default.jpg";
        public String ImageName { get { return _imageName; } set { _imageName = value; } }
        public String Story { get; set; }
    }
}
