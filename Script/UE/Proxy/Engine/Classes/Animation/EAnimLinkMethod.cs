using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimLinkMethod")]
	public enum EAnimLinkMethod : byte
	{
		Absolute = 0,
		Relative = 1,
		Proportional = 2,
	}
}