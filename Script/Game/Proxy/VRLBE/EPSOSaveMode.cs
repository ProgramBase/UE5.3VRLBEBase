using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EPSOSaveMode")]
	public enum EPSOSaveMode : byte
	{
		Incremental = 0,
		BoundPSOsOnly = 1,
		SortedBoundPSOs = 2,
	}
}