using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ERecomputeUVsPropertiesLayoutType")]
	public enum ERecomputeUVsPropertiesLayoutType : int
	{
		None = 0,
		Repack = 1,
		NormalizeToExistingBounds = 2,
		NormalizeToBounds = 3,
		NormalizeToWorld = 4,
	}
}