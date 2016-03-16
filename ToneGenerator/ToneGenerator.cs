using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NAudio.Wave;
using ToneGenerator.Extensions;

namespace ToneGenerator
{
  public partial class ToneGenerator : Form
  {
    private static bool IsPlaying;
    private readonly SineWaveOscillator Oscillator;
    private WaveOut WaveOut;

    public ToneGenerator() {
      InitializeComponent();
      trkFrequency.Value = int.Parse(txtFrequency.Text);
      Oscillator = new SineWaveOscillator();
      WaveOut = new WaveOut();
      if (WaveOut == null)
        throw new InvalidOperationException("Unable to play sound output. Could not create a Wave Output.");
      WaveOut.Init(Oscillator);
      txtFrequency_TextChanged(null, null);
    }

    ~ToneGenerator() {
      if (IsPlaying)
        WaveOut.Stop();
      WaveOut.Dispose();
      WaveOut = null;
    }

    private void btnMinus_Click(object sender, EventArgs e) {
      double freq;
      if (!Double.TryParse(txtFrequency.Text, out freq)) return;
      txtFrequency.Text = freq - (double) numStep.Value > trkFrequency.Minimum ? (freq - (double) numStep.Value).ToString() : trkFrequency.Minimum.ToString();
    }

    private void btnPlay_Click(object sender, EventArgs e) {
      IsPlaying = !IsPlaying;

      if (IsPlaying) {
        btnPlay.Text = "■";
        WaveOut.Play();
      } else {
        btnPlay.Text = "►";
        WaveOut.Stop();
      }
    }

    private void btnPlus_Click(object sender, EventArgs e) {
      double freq;
      if (!Double.TryParse(txtFrequency.Text, out freq)) return;
      txtFrequency.Text = freq + (double) numStep.Value < trkFrequency.Maximum ? (freq + (double) numStep.Value).ToString() : trkFrequency.Maximum.ToString();
    }

    private void trkFrequency_Scroll(object sender, EventArgs e) {
      txtFrequency.Text = trkFrequency.Value.ToString();
    }

    private void txtFrequency_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar != '\b')
        e.Handled = !char.IsNumber(e.KeyChar);
    }

    private void txtFrequency_TextChanged(object sender, EventArgs e) {
      double freq;
      if (txtFrequency.Text.IsNullOrEmpty()) return;
      if (!double.TryParse(txtFrequency.Text, out freq)) {
        txtFrequency.Text = Regex.Replace(txtFrequency.Text, "[^0-9]", "");
        freq = txtFrequency.Text.Length > 0 ? double.Parse(txtFrequency.Text) : 440;
      }
      Oscillator.Frequency = freq;
      trkFrequency.Value = (int) freq;
    }
  }
}