using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EUpdatePositionMethod")]
	public enum EUpdatePositionMethod : byte
	{
		Play = 0,
		Jump = 1,
		Scrub = 2,
	}
}