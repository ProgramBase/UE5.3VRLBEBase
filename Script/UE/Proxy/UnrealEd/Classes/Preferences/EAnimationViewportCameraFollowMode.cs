using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EAnimationViewportCameraFollowMode")]
	public enum EAnimationViewportCameraFollowMode : byte
	{
		None = 0,
		Bounds = 1,
		Bone = 2,
		Root = 3,
	}
}