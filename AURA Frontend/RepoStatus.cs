using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AURA_Frontend
{
    public class RepoStatus
    {
        public enum eStatus { Done, Error, Warning, Running }

        private readonly eStatus r_Status;
        public Color Color { get; }

        public RepoStatus(eStatus i_Status)
        {
            r_Status = i_Status;
            Color = getStatusColor();
        }

        public RepoStatus(string i_Status)
        {
            r_Status = convertStringToStatus(i_Status);
            Color = getStatusColor();
        }

        public static implicit operator RepoStatus(eStatus i_Status)
        {
            return new RepoStatus(i_Status);
        }

        public static explicit operator RepoStatus(string i_Status)
        {
            return new RepoStatus(i_Status);
        }

        public override string ToString()
        {
            return r_Status.ToString();
        }

        private eStatus convertStringToStatus(string i_StatusStr)
        {
            if (Enum.TryParse(i_StatusStr, true, out eStatus status))            
                return status;            
            else
                return eStatus.Done;
        }

        private Color getStatusColor()
        {
            Color color;

            switch (r_Status)
            {
                case eStatus.Done: color = Color.Lime; break;
                case eStatus.Error: color = Color.Red; break;
                case eStatus.Warning: color = Color.Orange; break;
                case eStatus.Running: color = Color.DodgerBlue; break;
                default: color = Color.Gray; break;
            }

            return color;
        }
    }
}
