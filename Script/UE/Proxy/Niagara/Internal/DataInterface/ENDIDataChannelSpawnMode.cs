using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDIDataChannelSpawnMode")]
	public enum ENDIDataChannelSpawnMode : long
	{
		Override = 0,
		Accumulate = 1,
		None = 2,
		Max = 3,
	}
}