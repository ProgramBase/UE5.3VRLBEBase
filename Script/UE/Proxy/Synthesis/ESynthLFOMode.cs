using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynthLFOMode")]
	public enum ESynthLFOMode : byte
	{
		Sync = 0,
		OneShot = 1,
		Free = 2,
		Count = 3,
	}
}