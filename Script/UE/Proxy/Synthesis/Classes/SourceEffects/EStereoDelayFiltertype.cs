using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.EStereoDelayFiltertype")]
	public enum EStereoDelayFiltertype : byte
	{
		Lowpass = 0,
		Highpass = 1,
		Bandpass = 2,
		Notch = 3,
		Count = 4,
	}
}