using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationHookComponent")]
	public partial class FMovieSceneEvaluationHookComponent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationHookComponent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationHookComponent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationHookComponent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationHookComponent A, FMovieSceneEvaluationHookComponent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationHookComponent A, FMovieSceneEvaluationHookComponent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationHookComponent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TScriptInterface<IMovieSceneEvaluationHook> Interface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __ReturnBuffer);

					return *(TScriptInterface<IMovieSceneEvaluationHook>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __InBuffer);
				}
			}
		}

		private static uint __Interface = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}