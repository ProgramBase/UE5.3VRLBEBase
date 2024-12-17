using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAutoExposureMethodUI")]
	public enum EAutoExposureMethodUI : byte
	{
		AEM_Histogram = 0,
		AEM_Basic = 1,
		AEM_Manual = 2,
	}
}