using Script.CoreUObject;

namespace Script.LiveCoding
{
	[PathName("/Script/LiveCoding.ELiveCodingStartupMode")]
	public enum ELiveCodingStartupMode : byte
	{
		Automatic = 0,
		AutomaticButHidden = 1,
		Manual = 2,
	}
}