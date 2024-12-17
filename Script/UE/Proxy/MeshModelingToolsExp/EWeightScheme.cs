using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EWeightScheme")]
	public enum EWeightScheme : int
	{
		Uniform = 0,
		Umbrella = 1,
		Valence = 2,
		MeanValue = 3,
		Cotangent = 4,
		ClampedCotangent = 5,
		IDTCotangent = 6,
	}
}