using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.ToolPresetAsset
{
	[PathName("/Script/ToolPresetAsset.InteractiveToolsPresetCollectionAsset")]
	public partial class UInteractiveToolsPresetCollectionAsset : UEditorConfigBase, IStaticClass
	{
		public TMap<FString, FInteractiveToolPresetStore> PerToolPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerToolPresets, __ReturnBuffer);

					return *(TMap<FString, FInteractiveToolPresetStore>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerToolPresets, __InBuffer);
				}
			}
		}

		public FText CollectionLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollectionLabel, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollectionLabel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolPresetAsset.InteractiveToolsPresetCollectionAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PerToolPresets = 0;

		private static uint __CollectionLabel = 0;
	}
}