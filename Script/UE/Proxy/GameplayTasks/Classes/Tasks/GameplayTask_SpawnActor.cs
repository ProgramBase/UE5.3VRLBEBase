using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTask_SpawnActor")]
	public partial class UGameplayTask_SpawnActor : UGameplayTask, IStaticClass
	{
		public FGameplayTaskSpawnActorDelegate Success
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Success, __ReturnBuffer);

					return *(FGameplayTaskSpawnActorDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Success, __InBuffer);
				}
			}
		}

		public FGameplayTaskSpawnActorDelegate DidNotSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DidNotSpawn, __ReturnBuffer);

					return *(FGameplayTaskSpawnActorDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DidNotSpawn, __InBuffer);
				}
			}
		}

		public TSubclassOf<AActor> ClassToSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClassToSpawn, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClassToSpawn, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTask_SpawnActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UGameplayTask_SpawnActor SpawnActor(TScriptInterface<IGameplayTaskOwnerInterface> TaskOwner, FVector SpawnLocation, FRotator SpawnRotation, TSubclassOf<AActor> Class, bool bSpawnOnlyOnAuthority = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = TaskOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SpawnRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSpawnOnlyOnAuthority;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnActor, __InBuffer, __ReturnBuffer);

				return *(UGameplayTask_SpawnActor*)__ReturnBuffer;
			}
		}

		public virtual void FinishSpawningActor(UObject WorldContextObject, AActor SpawnedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnedActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FinishSpawningActor, __InBuffer);
			}
		}

		public virtual bool BeginSpawningActor(UObject WorldContextObject, ref AActor SpawnedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnedActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __BeginSpawningActor, __InBuffer, __OutBuffer, __ReturnBuffer);

				SpawnedActor = *(AActor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Success = 0;

		private static uint __DidNotSpawn = 0;

		private static uint __ClassToSpawn = 0;

		private static uint __SpawnActor = 0;

		private static uint __FinishSpawningActor = 0;

		private static uint __BeginSpawningActor = 0;
	}
}