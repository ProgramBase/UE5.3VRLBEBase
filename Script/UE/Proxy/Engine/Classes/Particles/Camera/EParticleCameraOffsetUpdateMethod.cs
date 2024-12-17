using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleCameraOffsetUpdateMethod")]
	public enum EParticleCameraOffsetUpdateMethod : byte
	{
		EPCOUM_DirectSet = 0,
		EPCOUM_Additive = 1,
		EPCOUM_Scalar = 2,
	}
}