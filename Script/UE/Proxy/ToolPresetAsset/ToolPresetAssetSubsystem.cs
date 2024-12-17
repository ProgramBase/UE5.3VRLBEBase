using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.ToolPresetAsset
{
	[PathName("/Script/ToolPresetAsset.ToolPresetAssetSubsystem")]
	public partial class UToolPresetAssetSubsystem : UEditorSubsystem, IStaticClass
	{
		public UInteractiveToolsPresetCollectionAsset DefaultCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCollection, __ReturnBuffer);

					return *(UInteractiveToolsPresetCollectionAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCollection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolPresetAsset.ToolPresetAssetSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultCollection = 0;
	}
}