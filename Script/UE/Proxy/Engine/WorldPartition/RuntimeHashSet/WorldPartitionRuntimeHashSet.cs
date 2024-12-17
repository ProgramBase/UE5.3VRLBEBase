using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionRuntimeHashSet")]
	public partial class UWorldPartitionRuntimeHashSet : UWorldPartitionRuntimeHash, IStaticClass
	{
		public FRuntimePartitionDesc PersistentPartitionDesc
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PersistentPartitionDesc, __ReturnBuffer);

					return *(FRuntimePartitionDesc*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PersistentPartitionDesc, __InBuffer);
				}
			}
		}

		public TArray<FRuntimePartitionDesc> RuntimePartitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimePartitions, __ReturnBuffer);

					return *(TArray<FRuntimePartitionDesc>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimePartitions, __InBuffer);
				}
			}
		}

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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionRuntimeHashSet");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PersistentPartitionDesc = 0;

		private static uint __RuntimePartitions = 0;

		private static uint __NonSpatiallyLoadedRuntimeCells = 0;
	}
}