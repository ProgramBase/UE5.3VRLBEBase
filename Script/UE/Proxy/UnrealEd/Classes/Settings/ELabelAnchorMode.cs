using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ELabelAnchorMode")]
	public enum ELabelAnchorMode : byte
	{
		LabelAnchorMode_TopLeft = 0,
		LabelAnchorMode_TopCenter = 1,
		LabelAnchorMode_TopRight = 2,
		LabelAnchorMode_CenterLeft = 3,
		LabelAnchorMode_Centered = 4,
		LabelAnchorMode_CenterRight = 5,
		LabelAnchorMode_BottomLeft = 6,
		LabelAnchorMode_BottomCenter = 7,
		LabelAnchorMode_BottomRight = 8,
	}
}