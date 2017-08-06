using System.ComponentModel;
using System.Security.Permissions;

namespace DocScanSO
{
    [HostProtectionAttribute(SecurityAction.LinkDemand, SharedState = true)]
    public partial class BackgroundWorker : Component
    {
        public BackgroundWorker()
        {
            InitializeComponent();
        }

        public BackgroundWorker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
