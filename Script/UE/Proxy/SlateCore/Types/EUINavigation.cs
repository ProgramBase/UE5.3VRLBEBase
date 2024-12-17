using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EUINavigation")]
	public enum EUINavigation : byte
	{
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3,
		Next = 4,
		Previous = 5,
		Num = 6,
		Invalid = 7,
	}
}