using Script.CoreUObject;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.ELiveLinkCameraProjectionMode")]
	public enum ELiveLinkCameraProjectionMode : byte
	{
		Perspective = 0,
		Orthographic = 1,
	}
}