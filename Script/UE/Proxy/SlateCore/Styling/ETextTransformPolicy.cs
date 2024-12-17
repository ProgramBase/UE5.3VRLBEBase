using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ETextTransformPolicy")]
	public enum ETextTransformPolicy : byte
	{
		None = 0,
		ToLower = 1,
		ToUpper = 2,
	}
}