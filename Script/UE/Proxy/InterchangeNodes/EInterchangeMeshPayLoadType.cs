using Script.CoreUObject;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.EInterchangeMeshPayLoadType")]
	public enum EInterchangeMeshPayLoadType : byte
	{
		NONE = 0,
		STATIC = 1,
		SKELETAL = 2,
		MORPHTARGET = 3,
	}
}