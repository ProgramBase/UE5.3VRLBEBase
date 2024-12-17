using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.LevelVariantSetsActor")]
	public partial class ALevelVariantSetsActor : AActor, IStaticClass
	{
		public FSoftObjectPath LevelVariantSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelVariantSets, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelVariantSets, __InBuffer);
				}
			}
		}

		public TMap<TSubclassOf<UObject>, ULevelVariantSetsFunctionDirector> DirectorInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorInstances, __ReturnBuffer);

					return *(TMap<TSubclassOf<UObject>, ULevelVariantSetsFunctionDirector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorInstances, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.LevelVariantSetsActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SwitchOnVariantByName(FString VariantSetName, FString VariantName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VariantSetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SwitchOnVariantByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SwitchOnVariantByIndex(int VariantSetIndex, int VariantIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = VariantSetIndex;

				*(int*)(__InBuffer + 4) = VariantIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SwitchOnVariantByIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetLevelVariantSets(ULevelVariantSets InVariantSets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLevelVariantSets, __InBuffer);
			}
		}

		public virtual ULevelVariantSets GetLevelVariantSets(bool bLoad = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bLoad;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLevelVariantSets, __InBuffer, __ReturnBuffer);

				return *(ULevelVariantSets*)__ReturnBuffer;
			}
		}

		private static uint __LevelVariantSets = 0;

		private static uint __DirectorInstances = 0;

		private static uint __SwitchOnVariantByName = 0;

		private static uint __SwitchOnVariantByIndex = 0;

		private static uint __SetLevelVariantSets = 0;

		private static uint __GetLevelVariantSets = 0;
	}
}