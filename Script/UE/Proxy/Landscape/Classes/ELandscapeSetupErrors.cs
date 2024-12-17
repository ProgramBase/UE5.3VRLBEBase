using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeSetupErrors")]
	public enum ELandscapeSetupErrors : long
	{
		LSE_None = 0,
		LSE_NoLandscapeInfo = 1,
		LSE_CollsionXY = 2,
		LSE_NoLayerInfo = 3,
	}
}