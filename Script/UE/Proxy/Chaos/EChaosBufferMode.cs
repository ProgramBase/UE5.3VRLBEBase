using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EChaosBufferMode")]
	public enum EChaosBufferMode : byte
	{
		Double = 0,
		Triple = 1,
		Num = 2,
		Invalid = 3,
	}
}