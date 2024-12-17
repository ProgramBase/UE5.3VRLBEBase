using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionRuntimeSpatialHash")]
	public partial class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash, IStaticClass
	{
		public TArray<FSpatialHashRuntimeGrid> Grids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Grids, __ReturnBuffer);

					return *(TArray<FSpatialHashRuntimeGrid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Grids, __InBuffer);
				}
			}
		}

		public bool bPreviewGrids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPreviewGrids, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPreviewGrids, __InBuffer);
				}
			}
		}

		public int PreviewGridLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewGridLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewGridLevel, __InBuffer);
				}
			}
		}

		public FWorldPartitionRuntimeSpatialHashGridPreviewer GridPreviewer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GridPreviewer, __ReturnBuffer);

					return *(FWorldPartitionRuntimeSpatialHashGridPreviewer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GridPreviewer, __InBuffer);
				}
			}
		}

		public EWorldPartitionCVarProjectDefaultOverride UseAlignedGridLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UseAlignedGridLevels, __ReturnBuffer);

					return *(EWorldPartitionCVarProjectDefaultOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UseAlignedGridLevels, __InBuffer);
				}
			}
		}

		public EWorldPartitionCVarProjectDefaultOverride SnapNonAlignedGridLevelsToLowerLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapNonAlignedGridLevelsToLowerLevels, __ReturnBuffer);

					return *(EWorldPartitionCVarProjectDefaultOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapNonAlignedGridLevelsToLowerLevels, __InBuffer);
				}
			}
		}

		public EWorldPartitionCVarProjectDefaultOverride PlaceSmallActorsUsingLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaceSmallActorsUsingLocation, __ReturnBuffer);

					return *(EWorldPartitionCVarProjectDefaultOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaceSmallActorsUsingLocation, __InBuffer);
				}
			}
		}

		public EWorldPartitionCVarProjectDefaultOverride PlacePartitionActorsUsingLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlacePartitionActorsUsingLocation, __ReturnBuffer);

					return *(EWorldPartitionCVarProjectDefaultOverride*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlacePartitionActorsUsingLocation, __InBuffer);
				}
			}
		}

		public bool bEnableZCulling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableZCulling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableZCulling, __InBuffer);
				}
			}
		}

		public TArray<FSpatialHashStreamingGrid> StreamingGrids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingGrids, __ReturnBuffer);

					return *(TArray<FSpatialHashStreamingGrid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingGrids, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionRuntimeSpatialHash");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Grids = 0;

		private static uint __bPreviewGrids = 0;

		private static uint __PreviewGridLevel = 0;

		private static uint __GridPreviewer = 0;

		private static uint __UseAlignedGridLevels = 0;

		private static uint __SnapNonAlignedGridLevelsToLowerLevels = 0;

		private static uint __PlaceSmallActorsUsingLocation = 0;

		private static uint __PlacePartitionActorsUsingLocation = 0;

		private static uint __bEnableZCulling = 0;

		private static uint __StreamingGrids = 0;
	}
}