using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EConsumeMouseWheel")]
	public enum EConsumeMouseWheel : byte
	{
		WhenScrollingPossible = 0,
		Always = 1,
		Never = 2,
	}
}