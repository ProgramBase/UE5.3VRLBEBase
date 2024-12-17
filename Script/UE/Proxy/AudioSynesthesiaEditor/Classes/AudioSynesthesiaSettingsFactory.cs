using Script.CoreUObject;
using Script.UnrealEd;
using Script.AudioSynesthesia;
using Script.Library;

namespace Script.AudioSynesthesiaEditor
{
	[PathName("/Script/AudioSynesthesiaEditor.AudioSynesthesiaSettingsFactory")]
	public partial class UAudioSynesthesiaSettingsFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UAudioSynesthesiaSettings> AudioSynesthesiaSettingsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioSynesthesiaSettingsClass, __ReturnBuffer);

					return *(TSubclassOf<UAudioSynesthesiaSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioSynesthesiaSettingsClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesiaEditor.AudioSynesthesiaSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AudioSynesthesiaSettingsClass = 0;
	}
}