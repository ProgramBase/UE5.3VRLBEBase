using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFFTWindowType")]
	public enum EFFTWindowType : byte
	{
		None = 0,
		Hamming = 1,
		Hann = 2,
		Blackman = 3,
	}
}