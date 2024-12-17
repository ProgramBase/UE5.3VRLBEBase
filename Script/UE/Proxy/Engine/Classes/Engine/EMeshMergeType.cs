using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshMergeType")]
	public enum EMeshMergeType : long
	{
		MeshMergeType_Default = 0,
		MeshMergeType_MergeActor = 1,
	}
}