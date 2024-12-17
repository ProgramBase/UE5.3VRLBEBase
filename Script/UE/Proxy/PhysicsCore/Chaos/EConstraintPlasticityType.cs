using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.EConstraintPlasticityType")]
	public enum EConstraintPlasticityType : byte
	{
		CCPT_Free = 0,
		CCPT_Shrink = 1,
		CCPT_Grow = 2,
	}
}