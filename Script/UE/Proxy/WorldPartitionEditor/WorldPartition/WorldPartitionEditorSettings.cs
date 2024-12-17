using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.UnrealEd;
using Script.Library;

namespace Script.WorldPartitionEditor
{
	[PathName("/Script/WorldPartitionEditor.WorldPartitionEditorSettings")]
	public partial class UWorldPartitionEditorSettings : UDeveloperSettings, IStaticClass
	{
		public TSubclassOf<UWorldPartitionConvertCommandlet> CommandletClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CommandletClass, __ReturnBuffer);

					return *(TSubclassOf<UWorldPartitionConvertCommandlet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CommandletClass, __InBuffer);
				}
			}
		}

		public int InstancedFoliageGridSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstancedFoliageGridSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstancedFoliageGridSize, __InBuffer);
				}
			}
		}

		public int MinimapLowQualityWorldUnitsPerPixelThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinimapLowQualityWorldUnitsPerPixelThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinimapLowQualityWorldUnitsPerPixelThreshold, __InBuffer);
				}
			}
		}

		public bool bDisableLoadingInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableLoadingInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableLoadingInEditor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionEditor.WorldPartitionEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CommandletClass = 0;

		private static uint __InstancedFoliageGridSize = 0;

		private static uint __MinimapLowQualityWorldUnitsPerPixelThreshold = 0;

		private static uint __bDisableLoadingInEditor = 0;
	}
}