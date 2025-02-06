#region Refrences
using System.Diagnostics;
using System;
using System.IO;
#endregion

namespace C_SHARK
{
    public partial class Splash : Form
    {
        #region Calling Method
        private readonly Agent agent;
        private readonly Portal portal;
        private readonly Bypass bypass;
        #endregion

        #region Constructor
        public Splash()
        {
            InitializeComponent();
            agent = new Agent();
            portal = new Portal();
            bypass = new Bypass();

            Timer.Tick += Timer_Tick;
            Timer.Start();
            LogMessage(agent.logMessageAC);
        }
        #endregion

        #region features
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();

            try
            {
                if (!portal.checkedin)
                {
                    portal.Show();
                }
                else
                {
                    bypass.Show();
                }

                LogMessage(agent.logMessageSR);
                this.Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void LogMessage(string message)
        {
            try
            {
                File.AppendAllText(agent.appLog(), message);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("Logging error: " + ex.Message);
            }
        }

        private void HandleException(Exception ex)
        {
            agent.x50444E52();
            agent.errorSender();
            // Additional error handling or logging can be added here
        }
        #endregion
    }
}
