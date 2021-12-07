using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingApp
{
    public partial class IDD_FORM : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public IDD_FORM()
        {
            InitializeComponent();

            /* Adds the event and the event handler for the method that will 
         process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 5000;
            myTimer.Start();

            //// Runs the timer, and raises the event.
            //while (exitFlag == false)
            //{
            //    // Processes all the events in the queue.
            //    Application.DoEvents();
            //}
        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();

            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com");
                if (reply != null)
                {
                    String msg = String.Format("Ping: {0}ms", reply.RoundtripTime);
                    IDE_PING_LIST.Items.Add(msg);
                    IDE_PING_LIST.SelectedIndex = IDE_PING_LIST.Items.Count - 1;

                    DateTime date = DateTime.Now;

                    String DateStr = date.ToString("dd/MM/yy");
                    String TimeStr = date.ToString("hh:mm:sstt");

                    String PingCountStr = String.Format("Pings: {0}", IDE_PING_LIST.Items.Count);
                    String PingLastStr = String.Format("Last Ping: {0} - {1}", DateStr, TimeStr);
                    IDC_PING_COUNT.Text = PingCountStr;
                    IDC_LAST_PING_DATETIME.Text = PingLastStr;
                }
            }
            catch (Exception ex)
            {
                
            }

            myTimer.Enabled = true;
        }
    }
}
