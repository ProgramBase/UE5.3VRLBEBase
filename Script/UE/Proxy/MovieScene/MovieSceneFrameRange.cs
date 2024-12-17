using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneFrameRange")]
	public partial class FMovieSceneFrameRange : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneFrameRange");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneFrameRange() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneFrameRange() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneFrameRange A, FMovieSceneFrameRange B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneFrameRange A, FMovieSceneFrameRange B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneFrameRange;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}