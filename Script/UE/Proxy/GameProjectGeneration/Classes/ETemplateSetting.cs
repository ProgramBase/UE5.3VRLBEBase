using Script.CoreUObject;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.ETemplateSetting")]
	public enum ETemplateSetting : int
	{
		Languages = 0,
		HardwareTarget = 1,
		GraphicsPreset = 2,
		StarterContent = 3,
		XR = 4,
		Raytracing = 5,
		All = 6,
	}
}