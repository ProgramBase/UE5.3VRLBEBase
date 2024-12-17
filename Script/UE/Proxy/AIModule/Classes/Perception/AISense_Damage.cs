using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISense_Damage")]
	public partial class UAISense_Damage : UAISense, IStaticClass
	{
		public TArray<FAIDamageEvent> RegisteredEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredEvents, __ReturnBuffer);

					return *(TArray<FAIDamageEvent>*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISense_Damage");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ReportDamageEvent(UObject WorldContextObject, AActor DamagedActor, AActor Instigator, float DamageAmount, FVector EventLocation, FVector HitLocation, FName Tag = null)
		{
			unsafe
			{
				Tag ??= new FName("None");

				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Instigator?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = DamageAmount;

				*(nint*)(__InBuffer + 28) = EventLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReportDamageEvent, __InBuffer);
			}
		}

		private static uint __RegisteredEvents = 0;

		private static uint __ReportDamageEvent = 0;
	}
}