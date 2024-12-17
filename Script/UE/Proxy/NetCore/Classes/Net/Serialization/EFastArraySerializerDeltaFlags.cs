using Script.CoreUObject;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.EFastArraySerializerDeltaFlags")]
	public enum EFastArraySerializerDeltaFlags : byte
	{
		None = 0,
		HasBeenSerialized = 1,
		HasDeltaBeenRequested = 2,
		IsUsingDeltaSerialization = 4,
	}
}