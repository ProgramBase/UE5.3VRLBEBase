using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvQueryTrace")]
	public enum EEnvQueryTrace : byte
	{
		None = 0,
		Navigation = 1,
		GeometryByChannel = 2,
		GeometryByProfile = 3,
		NavigationOverLedges = 4,
	}
}