namespace AURA_Frontend
{
    // This class is ONLY for constants like relative URIs, header names, etc.
    internal static class ApiConstants
    {
        internal static class Http
        {
            public const string k_BaseAddress = "http://localhost:5000/";
        }
        internal static class Key
        {
            public const string k_ValidateGithubKey = "key/github/validate";
            public const string k_GetGithubKey = "key/github/get";
            public const string k_GetLLMKey = "key/llm/get";
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
