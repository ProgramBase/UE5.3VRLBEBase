using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleUVFlipMode")]
	public enum EParticleUVFlipMode : byte
	{
		None = 0,
		FlipUV = 1,
		FlipUOnly = 2,
		FlipVOnly = 3,
		RandomFlipUV = 4,
		RandomFlipUOnly = 5,
		RandomFlipVOnly = 6,
		RandomFlipUVIndependent = 7,
	}
}