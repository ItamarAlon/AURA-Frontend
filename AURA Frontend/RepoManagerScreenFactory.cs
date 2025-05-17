using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public static class RepoManagerScreenFactory
    {
        private static readonly WeakValueDictionary<Repository, RepoManagerScreen> sr_RepoToScreenDict = new();

        public static RepoManagerScreen CreateScreen(Repository repo)
        {
            RepoManagerScreen screen;

            if (!sr_RepoToScreenDict.TryGetValue(repo, out screen))
            {
                screen = new RepoManagerScreen() { Repo = repo };
                sr_RepoToScreenDict[repo] = screen;
            }

            return screen;
        }
    }
}
