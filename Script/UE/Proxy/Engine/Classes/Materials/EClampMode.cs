using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EClampMode")]
	public enum EClampMode : byte
	{
		CMODE_Clamp = 0,
		CMODE_ClampMin = 1,
		CMODE_ClampMax = 2,
	}
}