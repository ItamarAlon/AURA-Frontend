namespace AURA_Frontend
{
    public class Repository
    {
        public string Name { get; set; }
        public RepoStatus Status { get; set; }

        private int version;
        private string? description = null;
        private string path;
        private DateTime creationTime;
    }
}
