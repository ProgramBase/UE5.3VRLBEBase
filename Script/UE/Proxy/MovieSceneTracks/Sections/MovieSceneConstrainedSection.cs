using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneConstrainedSection")]
	public partial class UMovieSceneConstrainedSection : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneConstrainedSection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieSceneTracks.MovieSceneConstrainedSection")]
	public interface IMovieSceneConstrainedSection : IInterface
	{
	}
}