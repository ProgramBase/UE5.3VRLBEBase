using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.LevelVariantSets")]
	public partial class ULevelVariantSets : UObject, IStaticClass
	{
		public UObject DirectorBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorBlueprint, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorBlueprint, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> DirectorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorClass, __InBuffer);
				}
			}
		}

		public TArray<UVariantSet> VariantSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VariantSets, __ReturnBuffer);

					return *(TArray<UVariantSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VariantSets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.LevelVariantSets");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UVariantSet GetVariantSetByName(FString VariantSetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariantSetName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVariantSetByName, __InBuffer, __ReturnBuffer);

				return *(UVariantSet*)__ReturnBuffer;
			}
		}

		public virtual UVariantSet GetVariantSet(int VariantSetIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = VariantSetIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVariantSet, __InBuffer, __ReturnBuffer);

				return *(UVariantSet*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVariantSets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumVariantSets, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __DirectorBlueprint = 0;

		private static uint __DirectorClass = 0;

		private static uint __VariantSets = 0;

		private static uint __GetVariantSetByName = 0;

		private static uint __GetVariantSet = 0;

		private static uint __GetNumVariantSets = 0;
	}
}