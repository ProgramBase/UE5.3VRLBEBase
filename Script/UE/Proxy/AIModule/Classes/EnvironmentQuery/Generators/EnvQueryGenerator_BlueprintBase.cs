using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryGenerator_BlueprintBase")]
	public partial class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator, IStaticClass
	{
		public FText GeneratorsActionDescription
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratorsActionDescription, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratorsActionDescription, __InBuffer);
				}
			}
		}

		public TSubclassOf<UEnvQueryContext> Context
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Context, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Context, __InBuffer);
				}
			}
		}

		public TSubclassOf<UEnvQueryItemType> GeneratedItemType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratedItemType, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryItemType>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratedItemType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryGenerator_BlueprintBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UObject GetQuerier()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetQuerier, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual void DoItemGenerationFromActors(TArray<AActor> ContextActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ContextActors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __DoItemGenerationFromActors, __InBuffer);
			}
		}

		public virtual void DoItemGeneration(TArray<FVector> ContextLocations)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ContextLocations?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __DoItemGeneration, __InBuffer);
			}
		}

		public virtual void AddGeneratedVector(FVector GeneratedVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GeneratedVector?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddGeneratedVector, __InBuffer);
			}
		}

		public virtual void AddGeneratedActor(AActor GeneratedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GeneratedActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddGeneratedActor, __InBuffer);
			}
		}

		private static uint __GeneratorsActionDescription = 0;

		private static uint __Context = 0;

		private static uint __GeneratedItemType = 0;

		private static uint __GetQuerier = 0;

		private static uint __DoItemGenerationFromActors = 0;

		private static uint __DoItemGeneration = 0;

		private static uint __AddGeneratedVector = 0;

		private static uint __AddGeneratedActor = 0;
	}
}