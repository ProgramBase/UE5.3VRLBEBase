using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioSpectrumType")]
	public enum EAudioSpectrumType : byte
	{
		MagnitudeSpectrum = 0,
		PowerSpectrum = 1,
		Decibel = 2,
	}
}