using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIPerceptionSystem")]
	public partial class UAIPerceptionSystem : UAISubsystem, IStaticClass
	{
		public TArray<UAISense> Senses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Senses, __ReturnBuffer);

					return *(TArray<UAISense>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Senses, __InBuffer);
				}
			}
		}

		public float PerceptionAgingRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerceptionAgingRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerceptionAgingRate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIPerceptionSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ReportPerceptionEvent(UObject WorldContextObject, UAISenseEvent PerceptionEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PerceptionEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReportPerceptionEvent, __InBuffer);
			}
		}

		public virtual void ReportEvent(UAISenseEvent PerceptionEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PerceptionEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReportEvent, __InBuffer);
			}
		}

		public static bool RegisterPerceptionStimuliSource(UObject WorldContextObject, TSubclassOf<UAISense> Sense, AActor Target)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sense?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Target?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RegisterPerceptionStimuliSource, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnPerceptionStimuliSourceEndPlay(AActor Actor, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPerceptionStimuliSourceEndPlay, __InBuffer);
			}
		}

		public static TSubclassOf<UAISense> GetSenseClassForStimulus(UObject WorldContextObject, FAIStimulus Stimulus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Stimulus?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSenseClassForStimulus, __InBuffer, __ReturnBuffer);

				return *(TSubclassOf<UAISense>*)__ReturnBuffer;
			}
		}

		private static uint __Senses = 0;

		private static uint __PerceptionAgingRate = 0;

		private static uint __ReportPerceptionEvent = 0;

		private static uint __ReportEvent = 0;

		private static uint __RegisterPerceptionStimuliSource = 0;

		private static uint __OnPerceptionStimuliSourceEndPlay = 0;

		private static uint __GetSenseClassForStimulus = 0;
	}
}