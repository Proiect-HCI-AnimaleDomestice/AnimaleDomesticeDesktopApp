using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferma
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"E:\Facultate\An 3\ProiectHCI\Ferma\ImagesVideos\rata.mov";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                case 0:    // Undefined
                    break;

                case 1:    // Stopped
                    break;

                case 2:    // Paused
                    break;

                case 3:    // Playing
                    break;

                case 4:    // ScanForward
                    break;

                case 5:    // ScanReverse
                    break;

                case 6:    // Buffering
                    break;

                case 7:    // Waiting
                    break;

                case 8:    // MediaEnded
                    Joc1 formJoc1 = new Joc1();
                    formJoc1.Tag = this;
                    formJoc1.Show(this);
                    Hide();
                    break;

                case 9:    // Transitioning
                    break;

                case 10:   // Ready
                    break;

                case 11:   // Reconnecting
                    break;

                case 12:   // Last
                    break;

                default:
                    break;
            }
        }
    }
}
