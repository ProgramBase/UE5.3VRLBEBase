using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESelectInfo")]
	public enum ESelectInfo : byte
	{
		OnKeyPress = 0,
		OnNavigation = 1,
		OnMouseClick = 2,
		Direct = 3,
	}
}