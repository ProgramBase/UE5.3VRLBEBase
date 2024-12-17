using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EGeometryCollectionCacheType")]
	public enum EGeometryCollectionCacheType : byte
	{
		None = 0,
		Record = 1,
		Play = 2,
		RecordAndPlay = 3,
	}
}