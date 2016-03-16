using System;
using NAudio.Wave;

namespace ToneGenerator
{
  public class SineWaveOscillator : WaveProvider16
  {
    double phaseAngle;

    public SineWaveOscillator(int sampleRate = 44100, short amplitude = 8192) :
      base(sampleRate, 1) {
      Amplitude = amplitude;
    }

    public double Frequency { set; get; }
    public short Amplitude { set; get; }

    public override int Read(short[] buffer, int offset, int sampleCount) {
      for (int index = 0; index < sampleCount; index++) {
        buffer[offset + index] = (short)(Amplitude * Math.Sin(phaseAngle));
        phaseAngle += 2 * Math.PI * Frequency / WaveFormat.SampleRate;

        if (phaseAngle > 2 * Math.PI)
          phaseAngle -= 2 * Math.PI;
      }
      return sampleCount;
    }
  }
}
