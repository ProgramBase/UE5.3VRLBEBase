using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISense_Prediction")]
	public partial class UAISense_Prediction : UAISense, IStaticClass
	{
		public TArray<FAIPredictionEvent> RegisteredEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredEvents, __ReturnBuffer);

					return *(TArray<FAIPredictionEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredEvents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISense_Prediction");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void RequestPawnPredictionEvent(APawn Requestor, AActor PredictedActor, float PredictionTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Requestor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PredictedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = PredictionTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RequestPawnPredictionEvent, __InBuffer);
			}
		}

		public static void RequestControllerPredictionEvent(AAIController Requestor, AActor PredictedActor, float PredictionTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Requestor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PredictedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = PredictionTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RequestControllerPredictionEvent, __InBuffer);
			}
		}

		private static uint __RegisteredEvents = 0;

		private static uint __RequestPawnPredictionEvent = 0;

		private static uint __RequestControllerPredictionEvent = 0;
	}
}