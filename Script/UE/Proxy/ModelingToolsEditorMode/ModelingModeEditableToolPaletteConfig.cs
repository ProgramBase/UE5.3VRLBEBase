using Script.CoreUObject;
using Script.EditorConfig;
using Script.WidgetRegistration;
using Script.Library;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.ModelingModeEditableToolPaletteConfig")]
	public partial class UModelingModeEditableToolPaletteConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FEditableToolPaletteSettings> EditableToolPalettes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditableToolPalettes, __ReturnBuffer);

					return *(TMap<FName, FEditableToolPaletteSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditableToolPalettes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingToolsEditorMode.ModelingModeEditableToolPaletteConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditableToolPalettes = 0;
	}
}