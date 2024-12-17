using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EDisplaceMeshToolDisplaceType")]
	public enum EDisplaceMeshToolDisplaceType : byte
	{
		Constant = 0,
		DisplacementMap = 1,
		RandomNoise = 2,
		PerlinNoise = 3,
		SineWave = 4,
	}
}