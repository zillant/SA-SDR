using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDRSharp.Radio;
using SDRSharp.RTLSDR;
using SDRSharp.PanView;

namespace Spectrum_analyzer
{
    class RTLSDR
    {
        static ComplexFifoStream _inputfifoBuffer;
        static SDRSharp.RTLSDR.SamplesAvailableEventArgs _inputbuffer = new SDRSharp.RTLSDR.SamplesAvailableEventArgs();

        static uint _SampleRate = 1024000;

        static RtlSdrIO RTLrcvr;
        static SpectrumAnalyzer SA = new SpectrumAnalyzer();
        //HackRFDevice hackRF = new HackRFDevice();

        public RTLSDR()
        {
            RTLrcvr = new RtlSdrIO();
        }
        public static void Dongle_Initialization()
        {
            RTLrcvr.Open();
            RTLrcvr.Device.Start();
            RTLrcvr.Device.SamplesAvailable += RTLSDR_SamplesAvailable;
            RTLrcvr.Device.Samplerate = _SampleRate;
            RTLrcvr.Device.UseRtlAGC = true;
            RTLrcvr.Device.UseTunerAGC = false;
            RTLrcvr.Device.Gain = RTLrcvr.Device.SupportedGains[1];
        }



        //private static unsafe void HackRF_SamplesAvailable(object sender, SamplesAvailableEventArgs inputbuffer)
        //{
        //    if (_inputfifoBuffer == null)
        //    {
        //        _inputfifoBuffer = new ComplexFifoStream(BlockMode.None);
        //    }

        //    if (_inputfifoBuffer.Length < _SampleRate)
        //    {
        //        _inputfifoBuffer.Write(inputbuffer.Buffer, inputbuffer.Length);
        //    }

        //}

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
    }
}

