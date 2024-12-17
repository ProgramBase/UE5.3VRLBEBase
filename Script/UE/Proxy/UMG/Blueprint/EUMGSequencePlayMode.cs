using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EUMGSequencePlayMode")]
	public enum EUMGSequencePlayMode : byte
	{
		Forward = 0,
		Reverse = 1,
		PingPong = 2,
	}
}