using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.EDebugTypeEnum")]
	public enum EDebugTypeEnum : byte
	{
		ChaosNiagara_DebugType_NoDebug = 0,
		ChaosNiagara_DebugType_ColorBySolver = 1,
		ChaosNiagara_DebugType_ColorByParticleIndex = 2,
		ChaosNiagara_Max = 3,
	}
}