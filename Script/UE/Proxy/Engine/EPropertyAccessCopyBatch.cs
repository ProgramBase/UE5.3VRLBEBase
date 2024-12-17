using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPropertyAccessCopyBatch")]
	public enum EPropertyAccessCopyBatch : long
	{
		InternalUnbatched = 0,
		ExternalUnbatched = 1,
		InternalBatched = 2,
		ExternalBatched = 3,
		Count = 4,
	}
}