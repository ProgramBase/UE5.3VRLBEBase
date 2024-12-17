using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynthStereoDelayMode")]
	public enum ESynthStereoDelayMode : byte
	{
		Normal = 0,
		Cross = 1,
		PingPong = 2,
		Count = 3,
	}
}