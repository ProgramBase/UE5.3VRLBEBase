using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.EFrictionCombineMode")]
	public enum EFrictionCombineMode : byte
	{
		Average = 0,
		Min = 1,
		Multiply = 2,
		Max = 3,
	}
}