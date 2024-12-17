using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.ESearchCaseMode")]
	public enum ESearchCaseMode : byte
	{
		CaseSensitive = 0,
		IgnoreCase = 1,
	}
}