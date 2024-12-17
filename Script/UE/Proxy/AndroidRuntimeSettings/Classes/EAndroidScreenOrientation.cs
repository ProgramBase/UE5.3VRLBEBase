using Script.CoreUObject;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.EAndroidScreenOrientation")]
	public enum EAndroidScreenOrientation : byte
	{
		Portrait = 0,
		ReversePortrait = 1,
		SensorPortrait = 2,
		Landscape = 3,
		ReverseLandscape = 4,
		SensorLandscape = 5,
		Sensor = 6,
		FullSensor = 7,
	}
}