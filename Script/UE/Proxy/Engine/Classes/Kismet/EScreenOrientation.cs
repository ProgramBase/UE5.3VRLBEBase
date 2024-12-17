using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EScreenOrientation")]
	public enum EScreenOrientation : byte
	{
		Unknown = 0,
		Portrait = 1,
		PortraitUpsideDown = 2,
		LandscapeLeft = 3,
		LandscapeRight = 4,
		FaceUp = 5,
		FaceDown = 6,
		PortraitSensor = 7,
		LandscapeSensor = 8,
		FullSensor = 9,
	}
}