using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.EStereoDelaySourceEffect")]
	public enum EStereoDelaySourceEffect : byte
	{
		Normal = 0,
		Cross = 1,
		PingPong = 2,
		Count = 3,
	}
}