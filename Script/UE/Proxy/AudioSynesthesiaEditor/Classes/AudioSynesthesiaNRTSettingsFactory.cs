using Script.CoreUObject;
using Script.UnrealEd;
using Script.AudioSynesthesia;
using Script.Library;

namespace Script.AudioSynesthesiaEditor
{
	[PathName("/Script/AudioSynesthesiaEditor.AudioSynesthesiaNRTSettingsFactory")]
	public partial class UAudioSynesthesiaNRTSettingsFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UAudioSynesthesiaNRTSettings> AudioSynesthesiaNRTSettingsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioSynesthesiaNRTSettingsClass, __ReturnBuffer);

					return *(TSubclassOf<UAudioSynesthesiaNRTSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioSynesthesiaNRTSettingsClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesiaEditor.AudioSynesthesiaNRTSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AudioSynesthesiaNRTSettingsClass = 0;
	}
}