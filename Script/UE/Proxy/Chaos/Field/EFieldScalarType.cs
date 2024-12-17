using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldScalarType")]
	public enum EFieldScalarType : byte
	{
		Scalar_ExternalClusterStrain = 0,
		Scalar_Kill = 1,
		Scalar_DisableThreshold = 2,
		Scalar_SleepingThreshold = 3,
		Scalar_InternalClusterStrain = 4,
		Scalar_DynamicConstraint = 5,
		Scalar_TargetMax = 6,
	}
}