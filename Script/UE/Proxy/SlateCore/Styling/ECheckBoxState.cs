using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ECheckBoxState")]
	public enum ECheckBoxState : byte
	{
		Unchecked = 0,
		Checked = 1,
		Undetermined = 2,
	}
}