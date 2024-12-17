using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.ESleepFamily")]
	public enum ESleepFamily : byte
	{
		Normal = 0,
		Sensitive = 1,
		Custom = 2,
	}
}