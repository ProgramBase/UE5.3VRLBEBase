using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneObjectBindingSpace")]
	public enum EMovieSceneObjectBindingSpace : long
	{
		Local = 0,
		Root = 1,
		Unused = 2,
	}
}