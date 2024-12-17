using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.ECollisionTraceFlag")]
	public enum ECollisionTraceFlag : byte
	{
		CTF_UseDefault = 0,
		CTF_UseSimpleAndComplex = 1,
		CTF_UseSimpleAsComplex = 2,
		CTF_UseComplexAsSimple = 3,
	}
}