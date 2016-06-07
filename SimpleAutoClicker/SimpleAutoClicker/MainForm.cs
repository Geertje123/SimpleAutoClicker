using System.Threading;
using System.Windows.Forms;

namespace SimpleAutoClicker {
    public partial class MainForm : Form {
        private int _interval = 8;
        private int _notificationDuration;
        private int _notificationTimeRemaining = -1;

        private bool _newNotification;

        private string _singleClickKey = "VK_F2";
        private string _autoClickKey = "VK_F4";
        private string _emergencyStopKey = "VK_CONTROL+VK_SHIFT+VK_MENU";

        public MainForm() {
            InitializeComponent();

            nmrInterval.Value = _interval;
            txtSingleClickKey.Text = _singleClickKey;
            txtAutoClickKey.Text = _autoClickKey;
            txtEmergencyStopKey.Text = _emergencyStopKey;
            lblNotification.Text = "";

            new Thread(StartLooping) { IsBackground = true }.Start();
        }

        private void btnSetInterval_Click(object sender, System.EventArgs e) {
            _interval = (int)nmrInterval.Value;
            DisplayNotification("Interval set!");
        }

        private void btnSetSingleClickKey_Click(object sender, System.EventArgs e) {
            _singleClickKey = txtSingleClickKey.Text;
            DisplayNotification("Single click key set!");
        }

        private void btnSetAutoClickKey_Click(object sender, System.EventArgs e) {
            _autoClickKey = txtAutoClickKey.Text;
            DisplayNotification("Auto click key set!");
        }

        private void btnSetEmergencyStopKey_Click(object sender, System.EventArgs e) {
            _emergencyStopKey = txtEmergencyStopKey.Text;
            DisplayNotification("Emergency stop key set!");
        }

        private void DisplayNotification(string message, int time = 200) {
            lblNotification.Text = message;
            _notificationDuration = time;
            _newNotification = true;
        }

        private void StartLooping() {
            while (true) {
                if (_newNotification) {
                    _notificationTimeRemaining = _notificationDuration;
                    _newNotification = false;
                }
                if (_notificationTimeRemaining > 0) {
                    _notificationTimeRemaining--;
                }
                if (_notificationTimeRemaining == 0) {
                    if (lblNotification.InvokeRequired) {
                        lblNotification.Invoke(new MethodInvoker(() => { lblNotification.Text = ""; }));
                    } else {
                        lblNotification.Text = "";
                    }
                    _notificationTimeRemaining = -1;
                }
                Thread.Sleep(1);
            }
        }
    }
}
