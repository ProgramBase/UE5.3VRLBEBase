using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.EGranularSynthSeekType")]
	public enum EGranularSynthSeekType : byte
	{
		FromBeginning = 0,
		FromCurrentPosition = 1,
		Count = 2,
	}
}