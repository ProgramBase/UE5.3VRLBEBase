using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EInterpToBehaviourType")]
	public enum EInterpToBehaviourType : byte
	{
		OneShot = 0,
		OneShot_Reverse = 1,
		Loop_Reset = 2,
		PingPong = 3,
	}
}