using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EOcclusionCalculationUIMode")]
	public enum EOcclusionCalculationUIMode : byte
	{
		GeneralizedWindingNumber = 0,
		RaycastOcclusionSamples = 1,
	}
}