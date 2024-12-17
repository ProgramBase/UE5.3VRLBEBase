using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVectorNoiseFunction")]
	public enum EVectorNoiseFunction : byte
	{
		VNF_CellnoiseALU = 0,
		VNF_VectorALU = 1,
		VNF_GradientALU = 2,
		VNF_CurlALU = 3,
		VNF_VoronoiALU = 4,
	}
}