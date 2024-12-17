using Script.CoreUObject;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.EInterchangeForceMeshType")]
	public enum EInterchangeForceMeshType : byte
	{
		IFMT_None = 0,
		IFMT_StaticMesh = 1,
		IFMT_SkeletalMesh = 2,
	}
}