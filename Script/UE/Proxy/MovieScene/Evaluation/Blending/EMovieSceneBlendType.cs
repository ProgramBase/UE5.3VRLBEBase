using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneBlendType")]
	public enum EMovieSceneBlendType : byte
	{
		Invalid = 0,
		Absolute = 1,
		Additive = 2,
		Relative = 4,
		AdditiveFromBase = 8,
	}
}