﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace VirtualLoopPedal
{
    public partial class Pedal : Form
    {
        List<Looper> loopers;
        Looper selectedLooper = null;
        int looperCount = 0;
        public WaveFormat waveFormat;
        public Driver driver;
        public int WaveOutDeviceNumber = 0;
        public int WaveInDeviceNumber = 0;
        public string AsioDeviceName;

        public Pedal()
        {
            Reset();
            InitializeComponent();

            loopers = new List<Looper>();
            AddLooper(looper1);
            AddLooper(looper2);
            AddLooper(looper3);
            AddLooper(looper4);
            recorder.SetParent(this);
            metronome.SetParent(this);
        }

        public void Reset()
        {
            waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(Properties.Settings.Default.SampleRate, 1);
            driver = Properties.Settings.Default.Driver == "ASIO" ? Driver.ASIO : Driver.WaveEvent;

            recorder?.Recorder_Load(this, new EventArgs());
            metronome?.Metronome_Load(this, new EventArgs());
        }

        public Metronome GetMetronome()
        {
            return metronome;
        }

        public Recorder GetRecorder()
        {
            return recorder;
        }

        void AddLooper(Looper looper)
        {
            loopers.Add(looper);
            looper.SetName("Looper " + ++looperCount);
            looper.Click += looper_Click;
            looper.SetParent(this);
            metronome.Bar += looper.Metronome_Bar;
            metronome.Beat += looper.Metronome_Beat;
            metronome.Stopped += looper.Metronome_Stop;
        }

        /// <summary>
        /// Select Looper
        /// </summary>
        private void looper_Click(object sender, EventArgs e)
        {
            Looper l = sender as Looper;
            DeselectAllLoopers();
            l.Selected = true;
            selectedLooper = l;
        }

        private void DeselectAllLoopers()
        {
            foreach (Looper l in loopers)
                l.Selected = false;
        }

        private void button_addLooper_Click(object sender, EventArgs e)
        {
            Looper l = new Looper();
            AddLooper(l);
            flowLayoutPanel_loopers.Controls.Add(l);
        }

        private void button_deleteLooper_Click(object sender, EventArgs e)
        {
            loopers.Remove(selectedLooper);
            selectedLooper?.Dispose();
            selectedLooper = null;
        }

        private void Pedal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    looper_Click(loopers[0], new EventArgs());
                    break;
                case Keys.G:
                    looper_Click(loopers[1], new EventArgs());
                    break;
                case Keys.H:
                    looper_Click(loopers[2], new EventArgs());
                    break;
                case Keys.J:
                    looper_Click(loopers[3], new EventArgs());
                    break;
                case Keys.V:
                    // TODO: next looper
                    break;
                case Keys.C:
                    // TODO: previous looper
                    break;
                case Keys.M:
                    metronome.checkBox_metronome.Checked = !metronome.checkBox_metronome.Checked;
                    break;
                case Keys.R:
                case Keys.N:
                    selectedLooper?.RecordOrStop();
                    break;
                case Keys.B:
                case Keys.P:
                    selectedLooper?.PlayOrPause();
                    break;
                case Keys.Space:
                    metronome.StartOrStop();
                    break;
                case Keys.X:
                    metronome.EmergencyStop();
                    break;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Focus();
            }
        }

        private void button_tempoTool_Click(object sender, EventArgs e)
        {
            TempoTool tempoTool = new TempoTool();
            tempoTool.Show();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            metronome.EmergencyStop();
            Settings settings = new Settings();
            DialogResult result = settings.ShowDialog(this);

            if(result == DialogResult.OK)
            {
                WaveOutDeviceNumber = settings.WaveOutDeviceNumber;
                WaveInDeviceNumber = settings.WaveInDeviceNumber;
                AsioDeviceName = settings.AsioDeviceName;

                Properties.Settings.Default.SampleRate = settings.SampleRate;
                Properties.Settings.Default.Driver = settings.SelectedDriver == Driver.ASIO ? "ASIO" : "WaveEvent";
                Properties.Settings.Default.Save();

                Reset();
            }
        }
    }

    public enum Driver { WaveEvent, ASIO }
}
