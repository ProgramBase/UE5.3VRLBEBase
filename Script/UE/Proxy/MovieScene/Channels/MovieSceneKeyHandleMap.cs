using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneKeyHandleMap")]
	public partial class FMovieSceneKeyHandleMap : FKeyHandleLookupTable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneKeyHandleMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneKeyHandleMap()
		{
		}

		public static bool operator ==(FMovieSceneKeyHandleMap A, FMovieSceneKeyHandleMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneKeyHandleMap A, FMovieSceneKeyHandleMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneKeyHandleMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}