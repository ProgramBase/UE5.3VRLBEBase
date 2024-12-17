using Script.CoreUObject;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.ERedirectFixupMode")]
	public enum ERedirectFixupMode : long
	{
		DeleteFixedUpRedirectors = 0,
		LeaveFixedUpRedirectors = 1,
	}
}