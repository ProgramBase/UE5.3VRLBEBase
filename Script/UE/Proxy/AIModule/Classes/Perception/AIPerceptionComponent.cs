using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIPerceptionComponent")]
	public partial class UAIPerceptionComponent : UActorComponent, IStaticClass
	{
		public TArray<UAISenseConfig> SensesConfig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SensesConfig, __ReturnBuffer);

					return *(TArray<UAISenseConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SensesConfig, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAISense> DominantSense
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DominantSense, __ReturnBuffer);

					return *(TSubclassOf<UAISense>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DominantSense, __InBuffer);
				}
			}
		}

		public AAIController AIOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AIOwner, __ReturnBuffer);

					return *(AAIController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AIOwner, __InBuffer);
				}
			}
		}

		public FPerceptionUpdatedDelegate OnPerceptionUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPerceptionUpdated, __ReturnBuffer);

					return *(FPerceptionUpdatedDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPerceptionUpdated, __InBuffer);
				}
			}
		}

		public FActorPerceptionForgetUpdatedDelegate OnTargetPerceptionForgotten
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTargetPerceptionForgotten, __ReturnBuffer);

					return *(FActorPerceptionForgetUpdatedDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTargetPerceptionForgotten, __InBuffer);
				}
			}
		}

		public FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTargetPerceptionUpdated, __ReturnBuffer);

					return *(FActorPerceptionUpdatedDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTargetPerceptionUpdated, __InBuffer);
				}
			}
		}

		public FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTargetPerceptionInfoUpdated, __ReturnBuffer);

					return *(FActorPerceptionInfoUpdatedDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTargetPerceptionInfoUpdated, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIPerceptionComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSenseEnabled(TSubclassOf<UAISense> SenseClass, bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SenseClass?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSenseEnabled, __InBuffer);
			}
		}

		public virtual void RequestStimuliListenerUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestStimuliListenerUpdate);
			}
		}

		public virtual void OnOwnerEndPlay(AActor Actor, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnOwnerEndPlay, __InBuffer);
			}
		}

		public virtual void GetPerceivedHostileActorsBySense(TSubclassOf<UAISense> SenseToUse, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SenseToUse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPerceivedHostileActorsBySense, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual void GetPerceivedHostileActors(ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPerceivedHostileActors, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual void GetKnownPerceivedActors(TSubclassOf<UAISense> SenseToUse, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SenseToUse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetKnownPerceivedActors, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual void GetCurrentlyPerceivedActors(TSubclassOf<UAISense> SenseToUse, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SenseToUse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCurrentlyPerceivedActors, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual bool GetActorsPerception(AActor Actor, ref FActorPerceptionBlueprintInfo Info)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Info?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetActorsPerception, __InBuffer, __OutBuffer, __ReturnBuffer);

				Info = *(FActorPerceptionBlueprintInfo*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ForgetAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForgetAll);
			}
		}

		private static uint __SensesConfig = 0;

		private static uint __DominantSense = 0;

		private static uint __AIOwner = 0;

		private static uint __OnPerceptionUpdated = 0;

		private static uint __OnTargetPerceptionForgotten = 0;

		private static uint __OnTargetPerceptionUpdated = 0;

		private static uint __OnTargetPerceptionInfoUpdated = 0;

		private static uint __SetSenseEnabled = 0;

		private static uint __RequestStimuliListenerUpdate = 0;

		private static uint __OnOwnerEndPlay = 0;

		private static uint __GetPerceivedHostileActorsBySense = 0;

		private static uint __GetPerceivedHostileActors = 0;

		private static uint __GetKnownPerceivedActors = 0;

		private static uint __GetCurrentlyPerceivedActors = 0;

		private static uint __GetActorsPerception = 0;

		private static uint __ForgetAll = 0;
	}
}