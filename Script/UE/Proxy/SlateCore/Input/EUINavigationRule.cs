using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EUINavigationRule")]
	public enum EUINavigationRule : byte
	{
		Escape = 0,
		Explicit = 1,
		Wrap = 2,
		Stop = 3,
		Custom = 4,
		CustomBoundary = 5,
		Invalid = 6,
	}
}