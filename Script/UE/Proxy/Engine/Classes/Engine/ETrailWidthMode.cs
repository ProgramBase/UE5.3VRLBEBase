using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETrailWidthMode")]
	public enum ETrailWidthMode : byte
	{
		ETrailWidthMode_FromCentre = 0,
		ETrailWidthMode_FromFirst = 1,
		ETrailWidthMode_FromSecond = 2,
	}
}