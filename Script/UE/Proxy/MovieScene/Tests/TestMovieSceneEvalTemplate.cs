using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.TestMovieSceneEvalTemplate")]
	public partial class FTestMovieSceneEvalTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.TestMovieSceneEvalTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestMovieSceneEvalTemplate()
		{
		}

		public static bool operator ==(FTestMovieSceneEvalTemplate A, FTestMovieSceneEvalTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestMovieSceneEvalTemplate A, FTestMovieSceneEvalTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestMovieSceneEvalTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}