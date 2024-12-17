using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.ETextFlowDirection")]
	public enum ETextFlowDirection : byte
	{
		Auto = 0,
		LeftToRight = 1,
		RightToLeft = 2,
		Culture = 3,
	}
}