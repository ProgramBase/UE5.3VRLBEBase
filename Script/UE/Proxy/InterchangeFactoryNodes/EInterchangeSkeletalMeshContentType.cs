using Script.CoreUObject;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.EInterchangeSkeletalMeshContentType")]
	public enum EInterchangeSkeletalMeshContentType : byte
	{
		All = 0,
		Geometry = 1,
		SkinningWeights = 2,
	}
}