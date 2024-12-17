using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETimelineLengthMode")]
	public enum ETimelineLengthMode : byte
	{
		TL_TimelineLength = 0,
		TL_LastKeyFrame = 1,
	}
}