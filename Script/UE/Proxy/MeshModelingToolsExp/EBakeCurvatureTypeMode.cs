using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EBakeCurvatureTypeMode")]
	public enum EBakeCurvatureTypeMode : int
	{
		MeanAverage = 0,
		Max = 1,
		Min = 2,
		Gaussian = 3,
	}
}