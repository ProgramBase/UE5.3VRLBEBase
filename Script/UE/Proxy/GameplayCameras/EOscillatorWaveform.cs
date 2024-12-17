using Script.CoreUObject;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.EOscillatorWaveform")]
	public enum EOscillatorWaveform : byte
	{
		SineWave = 0,
		PerlinNoise = 1,
	}
}