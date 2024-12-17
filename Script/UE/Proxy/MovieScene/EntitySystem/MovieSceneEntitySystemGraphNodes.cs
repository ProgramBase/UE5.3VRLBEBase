using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEntitySystemGraphNodes")]
	public partial class FMovieSceneEntitySystemGraphNodes : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEntitySystemGraphNodes");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEntitySystemGraphNodes() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEntitySystemGraphNodes() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEntitySystemGraphNodes A, FMovieSceneEntitySystemGraphNodes B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEntitySystemGraphNodes A, FMovieSceneEntitySystemGraphNodes B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEntitySystemGraphNodes;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}