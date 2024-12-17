using Script.CoreUObject;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.ECacheMode")]
	public enum ECacheMode : byte
	{
		None = 0,
		Play = 1,
		Record = 2,
	}
}