using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionLevelStreamingDynamic")]
	public partial class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic, IStaticClass
	{
		public ULevel RuntimeLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeLevel, __ReturnBuffer);

					return *(ULevel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeLevel, __InBuffer);
				}
			}
		}

		public bool bShouldBeAlwaysLoaded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldBeAlwaysLoaded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldBeAlwaysLoaded, __InBuffer);
				}
			}
		}

		public bool bShouldPerformStandardLevelLoading
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPerformStandardLevelLoading, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPerformStandardLevelLoading, __InBuffer);
				}
			}
		}

		public UActorContainer UnsavedActorsContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnsavedActorsContainer, __ReturnBuffer);

					return *(UActorContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnsavedActorsContainer, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UWorldPartitionRuntimeLevelStreamingCell> StreamingCell
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingCell, __ReturnBuffer);

					return *(TWeakObjectPtr<UWorldPartitionRuntimeLevelStreamingCell>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingCell, __InBuffer);
				}
			}
		}

		public UWorldPartition OuterWorldPartition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OuterWorldPartition, __ReturnBuffer);

					return *(UWorldPartition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OuterWorldPartition, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionLevelStreamingDynamic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RuntimeLevel = 0;

		private static uint __bShouldBeAlwaysLoaded = 0;

		private static uint __bShouldPerformStandardLevelLoading = 0;

		private static uint __UnsavedActorsContainer = 0;

		private static uint __StreamingCell = 0;

		private static uint __OuterWorldPartition = 0;
	}
}