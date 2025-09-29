using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Priority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread2));
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

            threadA.Priority = ThreadPriority.Highest;  // Thread A (Highest Priority)
            threadB.Priority = ThreadPriority.Normal;   // Thread B (Normal Priority)
            threadC.Priority = ThreadPriority.AboveNormal;  // Thread C (Above Normal Priority)
            threadD.Priority = ThreadPriority.BelowNormal;  // Thread D (Below Normal Priority)

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblStatus.Text = "-End of Thread-";
        }
    }
}
