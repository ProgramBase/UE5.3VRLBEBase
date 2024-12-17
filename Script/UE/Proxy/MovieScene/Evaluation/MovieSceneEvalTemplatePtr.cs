using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvalTemplatePtr")]
	public partial class FMovieSceneEvalTemplatePtr : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvalTemplatePtr");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvalTemplatePtr() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvalTemplatePtr() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvalTemplatePtr A, FMovieSceneEvalTemplatePtr B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvalTemplatePtr A, FMovieSceneEvalTemplatePtr B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvalTemplatePtr;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}