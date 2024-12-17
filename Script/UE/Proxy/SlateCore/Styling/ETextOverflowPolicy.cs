using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ETextOverflowPolicy")]
	public enum ETextOverflowPolicy : byte
	{
		Clip = 0,
		Ellipsis = 1,
	}
}