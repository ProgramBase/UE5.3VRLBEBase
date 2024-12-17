using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.ELocationYToSpawnEnum")]
	public enum ELocationYToSpawnEnum : byte
	{
		ChaosNiagara_LocationYToSpawn_None = 0,
		ChaosNiagara_LocationYToSpawn_Min = 1,
		ChaosNiagara_LocationYToSpawn_Max = 2,
		ChaosNiagara_LocationYToSpawn_MinMax = 3,
		ChaosNiagara_Max = 4,
	}
}