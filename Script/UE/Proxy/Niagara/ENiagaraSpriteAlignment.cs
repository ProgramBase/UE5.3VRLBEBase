using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSpriteAlignment")]
	public enum ENiagaraSpriteAlignment : byte
	{
		Unaligned = 0,
		VelocityAligned = 1,
		CustomAlignment = 2,
		Automatic = 3,
	}
}