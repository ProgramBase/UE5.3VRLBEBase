using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneChannelOverrideProvider")]
	public partial class UMovieSceneChannelOverrideProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneChannelOverrideProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneChannelOverrideProvider")]
	public interface IMovieSceneChannelOverrideProvider : IInterface
	{
	}
}