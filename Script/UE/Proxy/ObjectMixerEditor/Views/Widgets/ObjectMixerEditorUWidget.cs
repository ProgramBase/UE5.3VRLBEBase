using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerEditorUWidget")]
	public partial class UObjectMixerEditorUWidget : UWidget, IStaticClass
	{
		public FObjectMixerWidgetUserConfig ObjectMixerWidgetUserConfig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectMixerWidgetUserConfig, __ReturnBuffer);

					return *(FObjectMixerWidgetUserConfig*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectMixerWidgetUserConfig, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ObjectMixerEditor.ObjectMixerEditorUWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ObjectMixerWidgetUserConfig = 0;
	}
}