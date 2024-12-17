using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.MovieSceneConstraintChannel")]
	public partial class FMovieSceneConstraintChannel : FMovieSceneBoolChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Constraints.MovieSceneConstraintChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneConstraintChannel()
		{
		}

		public static bool operator ==(FMovieSceneConstraintChannel A, FMovieSceneConstraintChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneConstraintChannel A, FMovieSceneConstraintChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneConstraintChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}