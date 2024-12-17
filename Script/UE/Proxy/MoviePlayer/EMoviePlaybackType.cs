using Script.CoreUObject;

namespace Script.MoviePlayer
{
	[PathName("/Script/MoviePlayer.EMoviePlaybackType")]
	public enum EMoviePlaybackType : long
	{
		MT_Normal = 0,
		MT_Looped = 1,
		MT_LoadingLoop = 2,
	}
}