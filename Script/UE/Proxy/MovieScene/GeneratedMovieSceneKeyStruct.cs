using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.GeneratedMovieSceneKeyStruct")]
	public partial class FGeneratedMovieSceneKeyStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.GeneratedMovieSceneKeyStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeneratedMovieSceneKeyStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeneratedMovieSceneKeyStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeneratedMovieSceneKeyStruct A, FGeneratedMovieSceneKeyStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeneratedMovieSceneKeyStruct A, FGeneratedMovieSceneKeyStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeneratedMovieSceneKeyStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}