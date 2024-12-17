using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldPhysicsDefaultFields")]
	public enum EFieldPhysicsDefaultFields : long
	{
		Field_RadialIntMask = 0,
		Field_RadialFalloff = 1,
		Field_UniformVector = 2,
		Field_RadialVector = 3,
		Field_RadialVectorFalloff = 4,
	}
}