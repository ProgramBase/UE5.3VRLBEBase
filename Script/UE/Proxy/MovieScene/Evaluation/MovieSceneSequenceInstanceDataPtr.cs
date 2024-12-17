using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceInstanceDataPtr")]
	public partial class FMovieSceneSequenceInstanceDataPtr : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceInstanceDataPtr");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceInstanceDataPtr() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceInstanceDataPtr() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceInstanceDataPtr A, FMovieSceneSequenceInstanceDataPtr B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceInstanceDataPtr A, FMovieSceneSequenceInstanceDataPtr B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceInstanceDataPtr;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}