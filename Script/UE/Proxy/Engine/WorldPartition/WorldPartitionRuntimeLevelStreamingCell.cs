using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionRuntimeLevelStreamingCell")]
	public partial class UWorldPartitionRuntimeLevelStreamingCell : UWorldPartitionRuntimeCell, IStaticClass
	{
		public TArray<FWorldPartitionRuntimeCellObjectMapping> Packages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Packages, __ReturnBuffer);

					return *(TArray<FWorldPartitionRuntimeCellObjectMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Packages, __InBuffer);
				}
			}
		}

		public UWorldPartitionLevelStreamingDynamic LevelStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelStreaming, __ReturnBuffer);

					return *(UWorldPartitionLevelStreamingDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelStreaming, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionRuntimeLevelStreamingCell");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnLevelShown()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnLevelShown);
			}
		}

		public virtual void OnLevelHidden()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnLevelHidden);
			}
		}

		private static uint __Packages = 0;

		private static uint __LevelStreaming = 0;

		private static uint __OnLevelShown = 0;

		private static uint __OnLevelHidden = 0;
	}
}