namespace AURA_Frontend
{
    public class Repository
    {
        public string Name { get; set; }
        public RepoStatus Status { get; set; }

        public string Version { get; set; } = "1.0";
        public string? Description { get; set; } = "";
        public string? Path { get; set; } = null;
        public DateTime LastModifiedTime { get; set; } = new DateTime(1970, 1, 1);
    }
}
