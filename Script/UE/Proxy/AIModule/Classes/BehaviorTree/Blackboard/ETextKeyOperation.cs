using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.ETextKeyOperation")]
	public enum ETextKeyOperation : byte
	{
		Equal = 0,
		NotEqual = 1,
		Contain = 2,
		NotContain = 3,
	}
}