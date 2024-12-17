using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavLinkDirection")]
	public enum ENavLinkDirection : byte
	{
		BothWays = 0,
		LeftToRight = 1,
		RightToLeft = 2,
	}
}