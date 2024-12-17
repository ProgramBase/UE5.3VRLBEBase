using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EMatchRule")]
	public enum EMatchRule : byte
	{
		None = 0,
		MATCH = 1,
		IGNORE = 2,
	}
}