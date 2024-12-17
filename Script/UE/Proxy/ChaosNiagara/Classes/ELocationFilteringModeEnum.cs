using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.ELocationFilteringModeEnum")]
	public enum ELocationFilteringModeEnum : byte
	{
		ChaosNiagara_LocationFilteringMode_Inclusive = 0,
		ChaosNiagara_LocationFilteringMode_Exclusive = 1,
		ChaosNiagara_Max = 2,
	}
}