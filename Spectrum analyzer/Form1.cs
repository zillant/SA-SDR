using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDRSharp.RTLSDR;
using SDRSharp.Radio;

namespace Spectrum_analyzer
{
    public partial class Form1 : Form
    {
        static RtlSdrIO RTLrcvr;
        static ComplexFifoStream _inputfifoBuffer;
        static SDRSharp.RTLSDR.SamplesAvailableEventArgs _inputbuffer = new SDRSharp.RTLSDR.SamplesAvailableEventArgs();
        static uint _SampleRate = 1024000;
        //RTLSDR rtl;

        bool rcvstarted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblErr.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rcvstarted)
            {
                btnStart.Text = "START";
                RTLrcvr.Close();
                rcvstarted = false;
                return;
            }

            if (!rcvstarted)
            {
                if (rdbRTLSDR.Checked)
                {
                    RTLrcvr = new RtlSdrIO();
                    Dongle_Initialization();
                }
                btnStart.Text = "STOP";
                rcvstarted = true;
            }

        }

        #region RTLSDR
        public void Dongle_Initialization()
        {
            try
            {
                RTLrcvr.Open();
                RTLrcvr.Device.Start();
                RTLrcvr.Device.SamplesAvailable += RTLSDR_SamplesAvailable;
                RTLrcvr.Device.Samplerate = _SampleRate;
                RTLrcvr.Device.UseRtlAGC = true;
                RTLrcvr.Device.UseTunerAGC = false;
                RTLrcvr.Device.Gain = RTLrcvr.Device.SupportedGains[10];
                lblErr.Text = "RTLSDR is finded ";
            }
            catch (Exception ex)
            {
                lblErr.Text = $"Error:{ex.Message}";
            }
        
        }

        private static unsafe void RTLSDR_SamplesAvailable(object sender, SDRSharp.RTLSDR.SamplesAvailableEventArgs inputbuffer)
        {
            if (_inputfifoBuffer == null)
            {
                _inputfifoBuffer = new ComplexFifoStream(BlockMode.None);
            }

            if (_inputfifoBuffer.Length < _SampleRate)
            {
                _inputfifoBuffer.Write(inputbuffer.Buffer, inputbuffer.Length);
            }

        }

        #endregion 

    }
}
