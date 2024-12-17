using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimNodeDataFlags")]
	public enum EAnimNodeDataFlags : long
	{
		None = 0,
		HasInitialUpdateFunction = 1,
		HasBecomeRelevantFunction = 2,
		HasUpdateFunction = 4,
	}
}