using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneParameterSectionExtender")]
	public partial class UMovieSceneParameterSectionExtender : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneParameterSectionExtender");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieSceneTracks.MovieSceneParameterSectionExtender")]
	public interface IMovieSceneParameterSectionExtender : IInterface
	{
	}
}