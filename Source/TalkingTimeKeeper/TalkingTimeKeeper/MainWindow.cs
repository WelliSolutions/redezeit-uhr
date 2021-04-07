using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using TalkingTimeKeeper.Resources;

namespace TalkingTimeKeeper
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialSoundSetup();
        }

        private void InitialSoundSetup()
        {
            _audioFile = new Mp3FileReader("Resources\\countdown60s.mp3");
            _mediaPlayer.Init(_audioFile);
            _mediaPlayer.Volume = 0.2f;
            SetVolume();
        }

        private void btnNextSpeaker_Click(object sender, EventArgs e)
        {
            if (Speakers == null || Speakers.Count == 0)
            {
                Reset();
            }
            NextSpeaker();
        }

        private void Reset()
        {
            TalkingTime = TimeSpan.ParseExact(txtTalkingTime.Text, "m\\:ss", CultureInfo.CurrentUICulture);
            Speakers = txtSpeakers.Text.Trim().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (chkShuffle.Checked)
            {
                Speakers.Shuffle();
            }
            Spoken = new List<string>();
            Speaking = null;
        }

        private void NextSpeaker()
        {
            UpdateSpoken();

            Speaking = Speakers[0];
            Speakers.RemoveAt(0);
            lblCurrentSpeaker.Text = Speaking;

            SetLabelWithTooltip(lblToSpeak, Translations.PeopleToSpeak, Speakers);

            StartTimeTalking = DateTime.Now;
            tmrTalkingTime.Enabled = true;

            StopSecondsTicking();
        }

        private void SetLabelWithTooltip(Label label, string format, IList<string> list)
        {
            if (list == null) list = new List<string>();
            var people = string.Join(" ", list);
            label.Text = string.Format(format, people);
            tooltip.SetToolTip(label, people);
        }

        private void StopSecondsTicking()
        {
            tmrTickingSeconds.Enabled = false;
            _mediaPlayer.Stop();
            _audioFile.Position = 0;
            SecondsTicking = false;
        }

        private string Speaking { get; set; }

        private List<string> Spoken { get; set; }

        private IList<string> Speakers { get; set; }

        private TimeSpan TalkingTime { get; set; }

        private DateTime StartTimeTalking { get; set; }

        private TimeSpan TimeLeft
        {
            get
            {
                var timeTalked = DateTime.Now - StartTimeTalking;
                return TalkingTime - timeTalked;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            lblTimeLeft.Text = TimeLeft.ToString("m\\:ss");

            lblTimeLeft.ForeColor = SystemColors.ControlText;
            if (TimeLeft.TotalSeconds < TalkingTime.TotalSeconds / 4)
            {
                lblTimeLeft.ForeColor = Color.Orange;
                StartSecondsTicking();
            }
            if (TimeLeft.TotalSeconds < 0)
            {
                lblTimeLeft.Text = string.Format(Translations.NegativeTimeFormat, lblTimeLeft.Text);
                lblTimeLeft.ForeColor = Color.Red;
                PlayTimeOverSound();
            }
        }

        private void PlayTimeOverSound()
        {
            
        }

        private void StartSecondsTicking()
        {
            // tmrTickingSeconds.Enabled = true;
            if (!SecondsTicking)
            {
                if (TimeLeft.TotalSeconds <= 60)
                {
                    SecondsTicking = true;
                    _mediaPlayer.Play();
                }
            }
        }


        readonly WaveOut _mediaPlayer = new WaveOut(); // or WaveOutEvent()
        private Mp3FileReader _audioFile;

        private bool SecondsTicking { get; set; }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateSpoken();
            _mediaPlayer.Stop();
            SecondsTicking = false;
            tmrTalkingTime.Enabled = false;
            tmrTickingSeconds.Enabled = false;
            lblTimeLeft.ForeColor = SystemColors.ControlDark;
        }

        private void UpdateSpoken()
        {
            if (Speaking != null)
            {
                Spoken.Add(Speaking);
            }
            Speaking = null;
            lblCurrentSpeaker.Text = Translations.NobodySpeaking;
            SetLabelWithTooltip(lblSpoken, Translations.PeopleThatHaveSpoken, Spoken);
        }

        private void tmrTickingSeconds_Tick(object sender, EventArgs e)
        {

        }

        private void OnVolumeChange(object sender, EventArgs e)
        {
            SetVolume();
        }

        private void SetVolume()
        {
            var devEnum = new MMDeviceEnumerator();
            var defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            var volume = defaultDevice.AudioEndpointVolume;
            volume.MasterVolumeLevelScalar = trkVolume.Value / 100.0f;
        }



        private void OnResize(object sender, EventArgs e)
        {
            btnNextSpeakerSmall.Visible = Size == MinimumSize;
            btnStopSmall.Visible = Size == MinimumSize;
        }

        private void OnSmallWindow(object sender, EventArgs e)
        {
            if (Size == MinimumSize)
            {
                Size = MaximumSize;
                btnSmallWindow.Text = "«";
            }
            else
            {
                Size = MinimumSize;
                btnSmallWindow.Text = "»";
            }
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkTopMost.Checked;
        }
    }
}
