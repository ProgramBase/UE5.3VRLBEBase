using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.ERandomVelocityGenerationTypeEnum")]
	public enum ERandomVelocityGenerationTypeEnum : byte
	{
		ChaosNiagara_RandomVelocityGenerationType_RandomDistribution = 0,
		ChaosNiagara_RandomVelocityGenerationType_RandomDistributionWithStreamers = 1,
		ChaosNiagara_RandomVelocityGenerationType_CollisionNormalBased = 2,
		ChaosNiagara_Max = 3,
	}
}