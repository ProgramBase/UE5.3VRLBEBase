using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.ETextWrappingPolicy")]
	public enum ETextWrappingPolicy : byte
	{
		DefaultWrapping = 0,
		AllowPerCharacterWrapping = 1,
	}
}