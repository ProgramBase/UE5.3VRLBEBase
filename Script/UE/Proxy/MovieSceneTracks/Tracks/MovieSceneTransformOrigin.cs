using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneTransformOrigin")]
	public partial class UMovieSceneTransformOrigin : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneTransformOrigin");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieSceneTracks.MovieSceneTransformOrigin")]
	public interface IMovieSceneTransformOrigin : IInterface
	{
		 FTransform BP_GetTransformOrigin();
	}
}