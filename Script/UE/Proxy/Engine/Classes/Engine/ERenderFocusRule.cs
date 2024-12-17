using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERenderFocusRule")]
	public enum ERenderFocusRule : byte
	{
		Always = 0,
		NonPointer = 1,
		NavigationOnly = 2,
		Never = 3,
	}
}