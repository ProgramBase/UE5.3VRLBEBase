using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EDynamicBoxType")]
	public enum EDynamicBoxType : byte
	{
		Horizontal = 0,
		Vertical = 1,
		Wrap = 2,
		VerticalWrap = 3,
		Radial = 4,
		Overlay = 5,
	}
}