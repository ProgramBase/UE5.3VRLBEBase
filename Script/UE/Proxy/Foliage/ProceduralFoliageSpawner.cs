using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.ProceduralFoliageSpawner")]
	public partial class UProceduralFoliageSpawner : UObject, IStaticClass
	{
		public int RandomSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __InBuffer);
				}
			}
		}

		public float TileSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TileSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TileSize, __InBuffer);
				}
			}
		}

		public int NumUniqueTiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumUniqueTiles, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumUniqueTiles, __InBuffer);
				}
			}
		}

		public float MinimumQuadTreeSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinimumQuadTreeSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinimumQuadTreeSize, __InBuffer);
				}
			}
		}

		public TArray<FFoliageTypeObject> FoliageTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageTypes, __ReturnBuffer);

					return *(TArray<FFoliageTypeObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageTypes, __InBuffer);
				}
			}
		}

		public bool bUseOverrideFoliageTerrainMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseOverrideFoliageTerrainMaterials, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseOverrideFoliageTerrainMaterials, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideFoliageTerrainMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideFoliageTerrainMaterials, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UMaterialInterface>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideFoliageTerrainMaterials, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.ProceduralFoliageSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Simulate(int NumSteps = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumSteps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Simulate, __InBuffer);
			}
		}

		private static uint __RandomSeed = 0;

		private static uint __TileSize = 0;

		private static uint __NumUniqueTiles = 0;

		private static uint __MinimumQuadTreeSize = 0;

		private static uint __FoliageTypes = 0;

		private static uint __bUseOverrideFoliageTerrainMaterials = 0;

		private static uint __OverrideFoliageTerrainMaterials = 0;

		private static uint __Simulate = 0;
	}
}