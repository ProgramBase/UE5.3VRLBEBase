using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EMatchOperator")]
	public enum EMatchOperator : byte
	{
		None = 0,
		GREAT_THAN = 1,
		LESS_THAN = 2,
		EQUAL = 3,
	}
}