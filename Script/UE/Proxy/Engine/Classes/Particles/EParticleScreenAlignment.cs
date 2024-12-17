using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleScreenAlignment")]
	public enum EParticleScreenAlignment : byte
	{
		PSA_FacingCameraPosition = 0,
		PSA_Square = 1,
		PSA_Rectangle = 2,
		PSA_Velocity = 3,
		PSA_AwayFromCenter = 4,
		PSA_TypeSpecific = 5,
		PSA_FacingCameraDistanceBlend = 6,
	}
}