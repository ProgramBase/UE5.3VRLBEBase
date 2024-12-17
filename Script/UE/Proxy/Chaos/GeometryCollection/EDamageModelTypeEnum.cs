using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EDamageModelTypeEnum")]
	public enum EDamageModelTypeEnum : byte
	{
		Chaos_Damage_Model_UserDefined_Damage_Threshold = 0,
		Chaos_Damage_Model_Material_Strength_And_Connectivity_DamageThreshold = 1,
		Chaos_Max = 2,
	}
}