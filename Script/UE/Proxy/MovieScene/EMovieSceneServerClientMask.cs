using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneServerClientMask")]
	public enum EMovieSceneServerClientMask : long
	{
		None = 0,
		Server = 1,
		Client = 2,
		All = 3,
	}
}