using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EInitialVelocityTypeEnum")]
	public enum EInitialVelocityTypeEnum : byte
	{
		Chaos_Initial_Velocity_User_Defined = 0,
		Chaos_Initial_Velocity_None = 1,
		Chaos_Max = 2,
	}
}