using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.ECollisionTypeEnum")]
	public enum ECollisionTypeEnum : byte
	{
		Chaos_Volumetric = 0,
		Chaos_Surface_Volumetric = 1,
		Chaos_Max = 2,
	}
}