namespace nvQuickSite.Models
{
    public class Package
    {
        public string pid { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string url { get; set; }
        public string upgradeurl { get; set; }
        public bool keep { get; set; } = false;
    }
}
