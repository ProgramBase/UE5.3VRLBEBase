using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSignificanceLevel")]
	public enum EParticleSignificanceLevel : byte
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Critical = 3,
		Num = 4,
	}
}