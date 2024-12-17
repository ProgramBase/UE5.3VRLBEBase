using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESamplePlayerSeekType")]
	public enum ESamplePlayerSeekType : byte
	{
		FromBeginning = 0,
		FromCurrentPosition = 1,
		FromEnd = 2,
		Count = 3,
	}
}