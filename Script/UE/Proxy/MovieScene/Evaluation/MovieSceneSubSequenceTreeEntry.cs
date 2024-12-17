using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSubSequenceTreeEntry")]
	public partial class FMovieSceneSubSequenceTreeEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSubSequenceTreeEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSubSequenceTreeEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSubSequenceTreeEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSubSequenceTreeEntry A, FMovieSceneSubSequenceTreeEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSubSequenceTreeEntry A, FMovieSceneSubSequenceTreeEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSubSequenceTreeEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}