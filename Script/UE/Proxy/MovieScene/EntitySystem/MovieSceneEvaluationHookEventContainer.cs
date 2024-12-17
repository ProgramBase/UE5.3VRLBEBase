using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationHookEventContainer")]
	public partial class FMovieSceneEvaluationHookEventContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationHookEventContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationHookEventContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationHookEventContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationHookEventContainer A, FMovieSceneEvaluationHookEventContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationHookEventContainer A, FMovieSceneEvaluationHookEventContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationHookEventContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMovieSceneEvaluationHookEvent> Events
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Events, __ReturnBuffer);

					return *(TArray<FMovieSceneEvaluationHookEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Events, __InBuffer);
				}
			}
		}

		private static uint __Events = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}