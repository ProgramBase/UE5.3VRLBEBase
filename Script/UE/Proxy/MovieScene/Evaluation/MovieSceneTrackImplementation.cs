using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackImplementation")]
	public partial class FMovieSceneTrackImplementation : FMovieSceneEvalTemplateBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackImplementation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackImplementation()
		{
		}

		public static bool operator ==(FMovieSceneTrackImplementation A, FMovieSceneTrackImplementation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackImplementation A, FMovieSceneTrackImplementation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackImplementation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}