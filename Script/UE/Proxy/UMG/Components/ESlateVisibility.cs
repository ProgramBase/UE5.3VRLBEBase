using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.ESlateVisibility")]
	public enum ESlateVisibility : byte
	{
		Visible = 0,
		Collapsed = 1,
		Hidden = 2,
		HitTestInvisible = 3,
		SelfHitTestInvisible = 4,
	}
}