using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationHookSystem")]
	public partial class UMovieSceneEvaluationHookSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public TMap<FMovieSceneEvaluationInstanceKey, FMovieSceneEvaluationHookEventContainer> PendingEventsByRootInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingEventsByRootInstance, __ReturnBuffer);

					return *(TMap<FMovieSceneEvaluationInstanceKey, FMovieSceneEvaluationHookEventContainer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingEventsByRootInstance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneEvaluationHookSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PendingEventsByRootInstance = 0;
	}
}