using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISense_Touch")]
	public partial class UAISense_Touch : UAISense, IStaticClass
	{
		public TArray<FAITouchEvent> RegisteredEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredEvents, __ReturnBuffer);

					return *(TArray<FAITouchEvent>*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISense_Touch");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ReportTouchEvent(UObject WorldContextObject, AActor TouchReceiver, AActor OtherActor, FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TouchReceiver?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReportTouchEvent, __InBuffer);
			}
		}

		private static uint __RegisteredEvents = 0;

		private static uint __ReportTouchEvent = 0;
	}
}