using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AURA_Frontend.RepoStatus;

namespace AURA_Frontend
{
    public partial class StatusBar : UserControl
    {
        private RepoStatus m_Status;
        public RepoStatus Status
        {
            get => m_Status;
            set
            {
                m_Status = value;
                if (m_Status != null)
                {
                    dotIndicator1.DotColor = m_Status.Color;
                    statusLabel.Text = m_Status.ToString();
                }
            }
        }

        public StatusBar()
        {
            InitializeComponent();
        }

        public StatusBar(RepoStatus i_Status)
        {
            InitializeComponent();
            Status = i_Status;
        }
    }
}
