using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSortMode")]
	public enum ENiagaraSortMode : byte
	{
		None = 0,
		ViewDepth = 1,
		ViewDistance = 2,
		CustomAscending = 3,
		CustomDecending = 4,
	}
}