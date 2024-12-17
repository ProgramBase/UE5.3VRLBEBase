using Script.CoreUObject;
using Script.Library;

namespace Script.LightMixer
{
	[PathName("/Script/LightMixer.LightMixerEditorSettings")]
	public partial class ULightMixerEditorSettings : UObject, IStaticClass
	{
		public bool bHideObjectMixerMenuItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHideObjectMixerMenuItem, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHideObjectMixerMenuItem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LightMixer.LightMixerEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bHideObjectMixerMenuItem = 0;
	}
}