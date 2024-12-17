using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStereoLayerType")]
	public enum EStereoLayerType : byte
	{
		SLT_WorldLocked = 0,
		SLT_TrackerLocked = 1,
		SLT_FaceLocked = 2,
	}
}