using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvalTemplateBase")]
	public partial class FMovieSceneEvalTemplateBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvalTemplateBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvalTemplateBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvalTemplateBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvalTemplateBase A, FMovieSceneEvalTemplateBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvalTemplateBase A, FMovieSceneEvalTemplateBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvalTemplateBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}