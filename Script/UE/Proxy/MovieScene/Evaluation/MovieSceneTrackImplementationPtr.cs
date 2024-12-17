using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackImplementationPtr")]
	public partial class FMovieSceneTrackImplementationPtr : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackImplementationPtr");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackImplementationPtr() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackImplementationPtr() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackImplementationPtr A, FMovieSceneTrackImplementationPtr B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackImplementationPtr A, FMovieSceneTrackImplementationPtr B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackImplementationPtr;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}