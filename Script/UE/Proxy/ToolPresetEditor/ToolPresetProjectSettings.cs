using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.ToolPresetEditor
{
	[PathName("/Script/ToolPresetEditor.ToolPresetProjectSettings")]
	public partial class UToolPresetProjectSettings : UDeveloperSettings, IStaticClass
	{
		public TSet<FSoftObjectPath> LoadedPresetCollections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LoadedPresetCollections, __ReturnBuffer);

					return *(TSet<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LoadedPresetCollections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolPresetEditor.ToolPresetProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LoadedPresetCollections = 0;
	}
}