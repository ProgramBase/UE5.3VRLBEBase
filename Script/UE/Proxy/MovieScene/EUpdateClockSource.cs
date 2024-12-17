using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EUpdateClockSource")]
	public enum EUpdateClockSource : byte
	{
		Tick = 0,
		Platform = 1,
		Audio = 2,
		RelativeTimecode = 3,
		Timecode = 4,
		PlayEveryFrame = 5,
		Custom = 6,
	}
}