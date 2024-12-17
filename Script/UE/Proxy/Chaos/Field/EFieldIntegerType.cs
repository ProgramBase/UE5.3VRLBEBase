using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldIntegerType")]
	public enum EFieldIntegerType : byte
	{
		Integer_DynamicState = 0,
		Integer_ActivateDisabled = 1,
		Integer_CollisionGroup = 2,
		Integer_PositionAnimated = 3,
		Integer_PositionStatic = 4,
		Integer_TargetMax = 5,
	}
}