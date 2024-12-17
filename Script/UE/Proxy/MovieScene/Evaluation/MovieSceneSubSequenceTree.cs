using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSubSequenceTree")]
	public partial class FMovieSceneSubSequenceTree : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSubSequenceTree");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSubSequenceTree() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSubSequenceTree() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSubSequenceTree A, FMovieSceneSubSequenceTree B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSubSequenceTree A, FMovieSceneSubSequenceTree B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSubSequenceTree;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}