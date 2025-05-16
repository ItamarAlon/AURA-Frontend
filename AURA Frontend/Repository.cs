namespace AURA_Frontend
{
    public class Repository
    {
        public enum eStatus { Done, Error, Warning}
        public string Name { get; set; }
        public eStatus Status { get; set; }

        private int version;
        private string? description = null;
        private string path;
        private DateTime creationTime;
    }
}
