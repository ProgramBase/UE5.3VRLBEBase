using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EControlRigComponentSpace")]
	public enum EControlRigComponentSpace : byte
	{
		WorldSpace = 0,
		ActorSpace = 1,
		ComponentSpace = 2,
		RigSpace = 3,
		LocalSpace = 4,
		Max = 5,
	}
}