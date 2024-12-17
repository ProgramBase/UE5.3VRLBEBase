using Script.CoreUObject;

namespace Script.MediaPlate
{
	[PathName("/Script/MediaPlate.EMediaPlateEventState")]
	public enum EMediaPlateEventState : long
	{
		Play = 0,
		Open = 1,
		Close = 2,
		Pause = 3,
		Reverse = 4,
		Forward = 5,
		Rewind = 6,
	}
}