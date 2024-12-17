using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.ELocationXToSpawnEnum")]
	public enum ELocationXToSpawnEnum : byte
	{
		ChaosNiagara_LocationXToSpawn_None = 0,
		ChaosNiagara_LocationXToSpawn_Min = 1,
		ChaosNiagara_LocationXToSpawn_Max = 2,
		ChaosNiagara_LocationXToSpawn_MinMax = 3,
		ChaosNiagara_Max = 4,
	}
}