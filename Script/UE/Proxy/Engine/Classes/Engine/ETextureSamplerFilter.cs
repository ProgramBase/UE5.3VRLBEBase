using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureSamplerFilter")]
	public enum ETextureSamplerFilter : long
	{
		Point = 0,
		Bilinear = 1,
		Trilinear = 2,
		AnisotropicPoint = 3,
		AnisotropicLinear = 4,
	}
}