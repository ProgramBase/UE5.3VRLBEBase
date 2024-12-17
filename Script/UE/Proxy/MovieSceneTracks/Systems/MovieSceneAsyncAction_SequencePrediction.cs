using Script.CoreUObject;
using Script.Engine;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction")]
	public partial class UMovieSceneAsyncAction_SequencePrediction : UBlueprintAsyncActionBase, IStaticClass
	{
		public FMovieSceneActorPredictionResult Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(FMovieSceneActorPredictionResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		public FMovieSceneActorPredictionFailure Failure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Failure, __ReturnBuffer);

					return *(FMovieSceneActorPredictionFailure*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Failure, __InBuffer);
				}
			}
		}

		public UMovieSceneSequencePlayer SequencePlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePlayer, __ReturnBuffer);

					return *(UMovieSceneSequencePlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePlayer, __InBuffer);
				}
			}
		}

		public USceneComponent SceneComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Player">
		/// An active, currently playing sequence player to use for predicting the transform
		/// </param>
		/// <param name="TargetComponent">
		/// The component to predict a world transform for
		/// </param>
		/// <param name="TimeInSeconds">
		/// The time within the sequence to predict the transform at
		/// </param>
		/// <returns>
		/// An asynchronous prediction object that contains Result and Failure delegates
		/// </returns>
		public static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtTime(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, float TimeInSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = TimeInSeconds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PredictWorldTransformAtTime, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneAsyncAction_SequencePrediction*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// An active, currently playing sequence player to use for predicting the transform
		/// </param>
		/// <param name="TargetComponent">
		/// The component to predict a world transform for
		/// </param>
		/// <param name="FrameTime">
		/// The frame time to predict at in the sequence's display rate
		/// </param>
		/// <returns>
		/// An asynchronous prediction object that contains Result and Failure delegates
		/// </returns>
		public static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtFrame(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, FFrameTime FrameTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FrameTime?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PredictWorldTransformAtFrame, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneAsyncAction_SequencePrediction*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// An active, currently playing sequence player to use for predicting the transform
		/// </param>
		/// <param name="TargetComponent">
		/// The component to predict a world transform for
		/// </param>
		/// <param name="TimeInSeconds">
		/// The time within the sequence to predict the transform at
		/// </param>
		/// <returns>
		/// An asynchronous prediction object that contains Result and Failure delegates
		/// </returns>
		public static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtTime(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, float TimeInSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = TimeInSeconds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PredictLocalTransformAtTime, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneAsyncAction_SequencePrediction*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// An active, currently playing sequence player to use for predicting the transform
		/// </param>
		/// <param name="TargetComponent">
		/// The component to predict a world transform for
		/// </param>
		/// <param name="FrameTime">
		/// The frame time to predict at in the sequence's display rate
		/// </param>
		/// <returns>
		/// An asynchronous prediction object that contains Result and Failure delegates
		/// </returns>
		public static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtFrame(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, FFrameTime FrameTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FrameTime?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PredictLocalTransformAtFrame, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneAsyncAction_SequencePrediction*)__ReturnBuffer;
			}
		}

		private static uint __Result = 0;

		private static uint __Failure = 0;

		private static uint __SequencePlayer = 0;

		private static uint __SceneComponent = 0;

		private static uint __PredictWorldTransformAtTime = 0;

		private static uint __PredictWorldTransformAtFrame = 0;

		private static uint __PredictLocalTransformAtTime = 0;

		private static uint __PredictLocalTransformAtFrame = 0;
	}
}