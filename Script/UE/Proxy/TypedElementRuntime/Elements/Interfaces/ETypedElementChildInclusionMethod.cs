using Script.CoreUObject;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.ETypedElementChildInclusionMethod")]
	public enum ETypedElementChildInclusionMethod : byte
	{
		None = 0,
		Immediate = 1,
		Recursive = 2,
	}
}