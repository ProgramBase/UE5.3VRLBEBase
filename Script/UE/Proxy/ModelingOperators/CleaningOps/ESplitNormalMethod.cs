using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ESplitNormalMethod")]
	public enum ESplitNormalMethod : byte
	{
		UseExistingTopology = 0,
		FaceNormalThreshold = 1,
		FaceGroupID = 2,
		PerTriangle = 3,
		PerVertex = 4,
	}
}