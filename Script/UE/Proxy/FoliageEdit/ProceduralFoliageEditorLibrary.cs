using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.Foliage;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.ProceduralFoliageEditorLibrary")]
	public partial class UProceduralFoliageEditorLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.ProceduralFoliageEditorLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ResimulateProceduralFoliageVolumes(TArray<AProceduralFoliageVolume> ProceduralFoliageVolumes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProceduralFoliageVolumes?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResimulateProceduralFoliageVolumes, __InBuffer);
			}
		}

		public static void ResimulateProceduralFoliageComponents(TArray<UProceduralFoliageComponent> ProceduralFoliageComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProceduralFoliageComponents?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResimulateProceduralFoliageComponents, __InBuffer);
			}
		}

		public static void ClearProceduralFoliageVolumes(TArray<AProceduralFoliageVolume> ProceduralFoliageVolumes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProceduralFoliageVolumes?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearProceduralFoliageVolumes, __InBuffer);
			}
		}

		public static void ClearProceduralFoliageComponents(TArray<UProceduralFoliageComponent> ProceduralFoliageComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProceduralFoliageComponents?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearProceduralFoliageComponents, __InBuffer);
			}
		}

		private static uint __ResimulateProceduralFoliageVolumes = 0;

		private static uint __ResimulateProceduralFoliageComponents = 0;

		private static uint __ClearProceduralFoliageVolumes = 0;

		private static uint __ClearProceduralFoliageComponents = 0;
	}
}