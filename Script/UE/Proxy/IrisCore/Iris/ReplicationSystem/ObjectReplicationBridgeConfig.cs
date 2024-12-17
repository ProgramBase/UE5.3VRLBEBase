using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ObjectReplicationBridgeConfig")]
	public partial class UObjectReplicationBridgeConfig : UObject, IStaticClass
	{
		public TArray<FObjectReplicationBridgePollConfig> PollConfigs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PollConfigs, __ReturnBuffer);

					return *(TArray<FObjectReplicationBridgePollConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PollConfigs, __InBuffer);
				}
			}
		}

		public TArray<FObjectReplicationBridgeFilterConfig> FilterConfigs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterConfigs, __ReturnBuffer);

					return *(TArray<FObjectReplicationBridgeFilterConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterConfigs, __InBuffer);
				}
			}
		}

		public TArray<FObjectReplicationBridgePrioritizerConfig> PrioritizerConfigs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrioritizerConfigs, __ReturnBuffer);

					return *(TArray<FObjectReplicationBridgePrioritizerConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrioritizerConfigs, __InBuffer);
				}
			}
		}

		public TArray<FObjectReplicationBridgeDeltaCompressionConfig> DeltaCompressionConfigs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeltaCompressionConfigs, __ReturnBuffer);

					return *(TArray<FObjectReplicationBridgeDeltaCompressionConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeltaCompressionConfigs, __InBuffer);
				}
			}
		}

		public FName DefaultSpatialFilterName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultSpatialFilterName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultSpatialFilterName, __InBuffer);
				}
			}
		}

		public FName RequiredNetDriverChannelClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequiredNetDriverChannelClassName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequiredNetDriverChannelClassName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.ObjectReplicationBridgeConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PollConfigs = 0;

		private static uint __FilterConfigs = 0;

		private static uint __PrioritizerConfigs = 0;

		private static uint __DeltaCompressionConfigs = 0;

		private static uint __DefaultSpatialFilterName = 0;

		private static uint __RequiredNetDriverChannelClassName = 0;
	}
}