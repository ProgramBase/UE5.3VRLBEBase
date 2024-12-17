using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.ERadialImpulseFalloff")]
	public enum ERadialImpulseFalloff : byte
	{
		RIF_Constant = 0,
		RIF_Linear = 1,
	}
}