using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EDesignPreviewSizeMode")]
	public enum EDesignPreviewSizeMode : byte
	{
		FillScreen = 0,
		Custom = 1,
		CustomOnScreen = 2,
		Desired = 3,
		DesiredOnScreen = 4,
	}
}