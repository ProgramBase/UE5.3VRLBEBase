using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPropertyAccessBatchType")]
	public enum EPropertyAccessBatchType : long
	{
		Unbatched = 0,
		Batched = 1,
	}
}