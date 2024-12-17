using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENetRole")]
	public enum ENetRole : byte
	{
		ROLE_None = 0,
		ROLE_SimulatedProxy = 1,
		ROLE_AutonomousProxy = 2,
		ROLE_Authority = 3,
	}
}