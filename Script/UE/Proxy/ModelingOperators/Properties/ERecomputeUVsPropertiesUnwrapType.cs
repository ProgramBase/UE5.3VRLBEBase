using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ERecomputeUVsPropertiesUnwrapType")]
	public enum ERecomputeUVsPropertiesUnwrapType : int
	{
		ExpMap = 0,
		Conformal = 1,
		SpectralConformal = 2,
		IslandMerging = 3,
	}
}