using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESettingsLockedAxis")]
	public enum ESettingsLockedAxis : long
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3,
		Invalid = 4,
	}
}