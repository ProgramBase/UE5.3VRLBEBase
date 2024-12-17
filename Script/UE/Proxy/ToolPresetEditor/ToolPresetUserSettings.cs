using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.ToolPresetEditor
{
	[PathName("/Script/ToolPresetEditor.ToolPresetUserSettings")]
	public partial class UToolPresetUserSettings : UEditorConfigBase, IStaticClass
	{
		public TSet<FSoftObjectPath> EnabledPresetCollections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnabledPresetCollections, __ReturnBuffer);

					return *(TSet<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnabledPresetCollections, __InBuffer);
				}
			}
		}

		public bool bDefaultCollectionEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDefaultCollectionEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDefaultCollectionEnabled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolPresetEditor.ToolPresetUserSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EnabledPresetCollections = 0;

		private static uint __bDefaultCollectionEnabled = 0;
	}
}