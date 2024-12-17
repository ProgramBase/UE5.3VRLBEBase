using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDISceneCapture2DOffsetMode")]
	public enum ENDISceneCapture2DOffsetMode : byte
	{
		Disabled = 0,
		RelativeLocal = 1,
		RelativeWorld = 2,
		AbsoluteWorld = 3,
	}
}