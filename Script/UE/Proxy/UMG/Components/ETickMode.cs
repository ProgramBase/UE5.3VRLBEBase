using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.ETickMode")]
	public enum ETickMode : byte
	{
		Disabled = 0,
		Enabled = 1,
		Automatic = 2,
	}
}