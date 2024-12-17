using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETrail2SourceMethod")]
	public enum ETrail2SourceMethod : byte
	{
		PET2SRCM_Default = 0,
		PET2SRCM_Particle = 1,
		PET2SRCM_Actor = 2,
	}
}