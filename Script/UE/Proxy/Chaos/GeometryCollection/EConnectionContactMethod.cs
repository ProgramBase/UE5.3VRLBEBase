using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EConnectionContactMethod")]
	public enum EConnectionContactMethod : byte
	{
		None = 0,
		ConvexHullContactArea = 1,
	}
}