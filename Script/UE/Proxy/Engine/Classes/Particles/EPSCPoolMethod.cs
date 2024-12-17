using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPSCPoolMethod")]
	public enum EPSCPoolMethod : byte
	{
		None = 0,
		AutoRelease = 1,
		ManualRelease = 2,
		ManualRelease_OnComplete = 3,
		FreeInPool = 4,
	}
}