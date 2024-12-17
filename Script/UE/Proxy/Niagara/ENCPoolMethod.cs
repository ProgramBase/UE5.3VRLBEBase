using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENCPoolMethod")]
	public enum ENCPoolMethod : byte
	{
		None = 0,
		AutoRelease = 1,
		ManualRelease = 2,
		ManualRelease_OnComplete = 3,
		FreeInPool = 4,
	}
}