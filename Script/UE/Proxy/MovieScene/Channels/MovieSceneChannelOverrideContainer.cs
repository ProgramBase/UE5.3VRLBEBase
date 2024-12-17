using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneChannelOverrideContainer")]
	public partial class UMovieSceneChannelOverrideContainer : UMovieSceneSignedObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneChannelOverrideContainer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}