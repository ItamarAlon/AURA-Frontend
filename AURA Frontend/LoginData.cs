using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public sealed class LoginData
    {
        private static LoginData s_Instance;
        private static readonly object key = true;

        public string GitHubKey { get; set; }
        public string LLMKey { get; set; }

        private LoginData(){}
        public static LoginData Instance
        {
            get
            {
                if (s_Instance == null)
                    lock (key)
                        if (s_Instance == null)
                            s_Instance = new LoginData();

                return s_Instance;
            }
        }
    }
}
