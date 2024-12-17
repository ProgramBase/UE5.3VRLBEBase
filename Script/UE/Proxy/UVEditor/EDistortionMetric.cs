using Script.CoreUObject;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.EDistortionMetric")]
	public enum EDistortionMetric : byte
	{
		ReedBeta = 0,
		Sander_L2 = 1,
		Sander_LInf = 2,
		TexelDensity = 3,
	}
}