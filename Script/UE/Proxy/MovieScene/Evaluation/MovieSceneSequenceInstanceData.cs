using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceInstanceData")]
	public partial class FMovieSceneSequenceInstanceData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceInstanceData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceInstanceData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceInstanceData A, FMovieSceneSequenceInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceInstanceData A, FMovieSceneSequenceInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}