using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryContext_BlueprintBase")]
	public partial class UEnvQueryContext_BlueprintBase : UEnvQueryContext, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryContext_BlueprintBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ProvideSingleLocation(UObject QuerierObject, AActor QuerierActor, ref FVector ResultingLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = QuerierObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuerierActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ResultingLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __ProvideSingleLocation, __InBuffer, __OutBuffer);

				ResultingLocation = *(FVector*)(__OutBuffer);

			}
		}

		public virtual void ProvideSingleActor(UObject QuerierObject, AActor QuerierActor, ref AActor ResultingActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = QuerierObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuerierActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ResultingActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __ProvideSingleActor, __InBuffer, __OutBuffer);

				ResultingActor = *(AActor*)(__OutBuffer);

			}
		}

		public virtual void ProvideLocationsSet(UObject QuerierObject, AActor QuerierActor, ref TArray<FVector> ResultingLocationSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = QuerierObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuerierActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ResultingLocationSet?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __ProvideLocationsSet, __InBuffer, __OutBuffer);

				ResultingLocationSet = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public virtual void ProvideActorsSet(UObject QuerierObject, AActor QuerierActor, ref TArray<AActor> ResultingActorsSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = QuerierObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuerierActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ResultingActorsSet?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __ProvideActorsSet, __InBuffer, __OutBuffer);

				ResultingActorsSet = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		private static uint __ProvideSingleLocation = 0;

		private static uint __ProvideSingleActor = 0;

		private static uint __ProvideLocationsSet = 0;

		private static uint __ProvideActorsSet = 0;
	}
}