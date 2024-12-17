using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAutoExposureMethod")]
	public enum EAutoExposureMethod : byte
	{
		AEM_Histogram = 0,
		AEM_Basic = 1,
		AEM_Manual = 2,
	}
}