using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionLevelStreamingPolicy")]
	public partial class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy, IStaticClass
	{
		public FTopLevelAssetPath SourceWorldAssetPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceWorldAssetPath, __ReturnBuffer);

					return *(FTopLevelAssetPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceWorldAssetPath, __InBuffer);
				}
			}
		}

		public TMap<FName, FName> SubObjectsToCellRemapping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubObjectsToCellRemapping, __ReturnBuffer);

					return *(TMap<FName, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubObjectsToCellRemapping, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> ExternalStreamingObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExternalStreamingObjects, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExternalStreamingObjects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionLevelStreamingPolicy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SourceWorldAssetPath = 0;

		private static uint __SubObjectsToCellRemapping = 0;

		private static uint __ExternalStreamingObjects = 0;
	}
}