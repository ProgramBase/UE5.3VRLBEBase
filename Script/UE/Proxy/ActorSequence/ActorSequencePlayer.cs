using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.ActorSequence
{
	[PathName("/Script/ActorSequence.ActorSequencePlayer")]
	public partial class UActorSequencePlayer : UMovieSceneSequencePlayer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ActorSequence.ActorSequencePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}