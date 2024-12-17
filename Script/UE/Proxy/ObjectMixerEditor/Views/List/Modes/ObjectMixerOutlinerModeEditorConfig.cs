using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerOutlinerModeEditorConfig")]
	public partial class UObjectMixerOutlinerModeEditorConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FObjectMixerOutlinerModeConfig> Browsers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Browsers, __ReturnBuffer);

					return *(TMap<FName, FObjectMixerOutlinerModeConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Browsers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ObjectMixerEditor.ObjectMixerOutlinerModeEditorConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Browsers = 0;
	}
}