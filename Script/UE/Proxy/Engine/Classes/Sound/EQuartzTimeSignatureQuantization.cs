using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuartzTimeSignatureQuantization")]
	public enum EQuartzTimeSignatureQuantization : byte
	{
		HalfNote = 0,
		QuarterNote = 1,
		EighthNote = 2,
		SixteenthNote = 3,
		ThirtySecondNote = 4,
		Count = 5,
	}
}