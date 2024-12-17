using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.ByteChannelEvaluatorSystem")]
	public partial class UByteChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.ByteChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}