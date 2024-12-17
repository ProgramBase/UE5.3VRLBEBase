using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.AudioEditorSettings")]
	public partial class UAudioEditorSettings : UDeveloperSettings, IStaticClass
	{
		public bool bPinSoundCueInAssetMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundCueInAssetMenu, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundCueInAssetMenu, __InBuffer);
				}
			}
		}

		public bool bPinSoundCueTemplateInAssetMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundCueTemplateInAssetMenu, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundCueTemplateInAssetMenu, __InBuffer);
				}
			}
		}

		public bool bPinSoundAttenuationInAssetMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundAttenuationInAssetMenu, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundAttenuationInAssetMenu, __InBuffer);
				}
			}
		}

		public bool bPinSoundConcurrencyInAssetMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundConcurrencyInAssetMenu, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPinSoundConcurrencyInAssetMenu, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.AudioEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bPinSoundCueInAssetMenu = 0;

		private static uint __bPinSoundCueTemplateInAssetMenu = 0;

		private static uint __bPinSoundAttenuationInAssetMenu = 0;

		private static uint __bPinSoundConcurrencyInAssetMenu = 0;
	}
}