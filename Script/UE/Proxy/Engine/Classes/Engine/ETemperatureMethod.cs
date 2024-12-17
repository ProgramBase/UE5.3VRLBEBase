using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETemperatureMethod")]
	public enum ETemperatureMethod : byte
	{
		TEMP_WhiteBalance = 0,
		TEMP_ColorTemperature = 1,
	}
}