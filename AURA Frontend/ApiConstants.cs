namespace AURA_Frontend
{
    // This class is ONLY for constants like relative URIs, header names, etc.
    internal static class ApiConstants
    {
        internal static class Auth
        {
            public const string k_ValidateGithubKey = "auth/github/validate";
        }

        internal static class Aura
        {
            public const string k_Start = "aura/start";
        }

        internal static class Repos
        {
            public const string k_Clone = "repos/clone";
            public const string k_Last = "repos/last";
        }

        internal static class Chat
        {
            public const string k_Send = "chat/send";
        }
    }
}
