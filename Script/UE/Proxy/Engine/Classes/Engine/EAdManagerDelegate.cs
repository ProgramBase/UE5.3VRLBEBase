using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAdManagerDelegate")]
	public enum EAdManagerDelegate : long
	{
		AMD_ClickedBanner = 0,
		AMD_UserClosedAd = 1,
	}
}