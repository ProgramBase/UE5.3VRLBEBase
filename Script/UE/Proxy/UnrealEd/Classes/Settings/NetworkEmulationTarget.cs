using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.NetworkEmulationTarget")]
	public enum NetworkEmulationTarget : int
	{
		Server = 0,
		Client = 1,
		Any = 2,
	}
}