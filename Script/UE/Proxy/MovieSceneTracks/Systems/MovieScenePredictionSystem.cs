using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePredictionSystem")]
	public partial class UMovieScenePredictionSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public TArray<UMovieSceneAsyncAction_SequencePrediction> PendingPredictions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingPredictions, __ReturnBuffer);

					return *(TArray<UMovieSceneAsyncAction_SequencePrediction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingPredictions, __InBuffer);
				}
			}
		}

		public TArray<UMovieSceneAsyncAction_SequencePrediction> ProcessingPredictions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProcessingPredictions, __ReturnBuffer);

					return *(TArray<UMovieSceneAsyncAction_SequencePrediction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProcessingPredictions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePredictionSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PendingPredictions = 0;

		private static uint __ProcessingPredictions = 0;
	}
}