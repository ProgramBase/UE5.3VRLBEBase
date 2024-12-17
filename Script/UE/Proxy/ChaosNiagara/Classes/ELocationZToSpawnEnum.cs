using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.ELocationZToSpawnEnum")]
	public enum ELocationZToSpawnEnum : byte
	{
		ChaosNiagara_LocationZToSpawn_None = 0,
		ChaosNiagara_LocationZToSpawn_Min = 1,
		ChaosNiagara_LocationZToSpawn_Max = 2,
		ChaosNiagara_LocationZToSpawn_MinMax = 3,
		ChaosNiagara_Max = 4,
	}
}