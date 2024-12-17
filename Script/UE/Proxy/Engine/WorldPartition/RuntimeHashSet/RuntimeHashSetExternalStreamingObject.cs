using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeHashSetExternalStreamingObject")]
	public partial class URuntimeHashSetExternalStreamingObject : URuntimeHashExternalStreamingObjectBase, IStaticClass
	{
		public TArray<UWorldPartitionRuntimeCell> NonSpatiallyLoadedRuntimeCells
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NonSpatiallyLoadedRuntimeCells, __ReturnBuffer);

					return *(TArray<UWorldPartitionRuntimeCell>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NonSpatiallyLoadedRuntimeCells, __InBuffer);
				}
			}
		}

		public TArray<UWorldPartitionRuntimeCell> SpatiallyLoadedRuntimeCells
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpatiallyLoadedRuntimeCells, __ReturnBuffer);

					return *(TArray<UWorldPartitionRuntimeCell>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpatiallyLoadedRuntimeCells, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimeHashSetExternalStreamingObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NonSpatiallyLoadedRuntimeCells = 0;

		private static uint __SpatiallyLoadedRuntimeCells = 0;
	}
}