using Script.CoreUObject;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.ENavSystemOverridePolicy")]
	public enum ENavSystemOverridePolicy : byte
	{
		Override = 0,
		Append = 1,
		Skip = 2,
	}
}