using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMirrorRowType")]
	public enum EMirrorRowType : byte
	{
		Bone = 0,
		AnimationNotify = 1,
		Curve = 2,
		SyncMarker = 3,
		Custom = 4,
	}
}