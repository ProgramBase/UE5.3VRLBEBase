using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENoiseFunction")]
	public enum ENoiseFunction : byte
	{
		NOISEFUNCTION_SimplexTex = 0,
		NOISEFUNCTION_GradientTex = 1,
		NOISEFUNCTION_GradientTex3D = 2,
		NOISEFUNCTION_GradientALU = 3,
		NOISEFUNCTION_ValueALU = 4,
		NOISEFUNCTION_VoronoiALU = 5,
	}
}