using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EInertializationState")]
	public enum EInertializationState : long
	{
		Inactive = 0,
		Pending = 1,
		Active = 2,
	}
}