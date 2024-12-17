using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EProgressBarFillType")]
	public enum EProgressBarFillType : byte
	{
		LeftToRight = 0,
		RightToLeft = 1,
		FillFromCenter = 2,
		FillFromCenterHorizontal = 3,
		FillFromCenterVertical = 4,
		TopToBottom = 5,
		BottomToTop = 6,
	}
}