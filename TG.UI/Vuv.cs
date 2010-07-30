using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace TG.UI
{
    class Vuv
    {
        private SoundPlayer _spWave;
        private Boolean _isVuv = false;

        private const String filepath = "Resources\\Sounds\\vuvuzela.wav";

        //TODO: make enum with different vuv sounds - call constructor based on emotion.
        public Vuv()
        {
            _spWave = new SoundPlayer(filepath);
        }

        public void TogglePlaying()
        {
            if (_isVuv) _spWave.Stop();
            else _spWave.PlayLooping();

            _isVuv = !_isVuv;
        }
    }
}
