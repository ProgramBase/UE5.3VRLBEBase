using Script.CoreUObject;
using Script.UnrealEd;
using Script.AudioSynesthesia;
using Script.Library;

namespace Script.AudioSynesthesiaEditor
{
	[PathName("/Script/AudioSynesthesiaEditor.AudioSynesthesiaNRTFactory")]
	public partial class UAudioSynesthesiaNRTFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UAudioSynesthesiaNRT> AudioSynesthesiaNRTClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioSynesthesiaNRTClass, __ReturnBuffer);

					return *(TSubclassOf<UAudioSynesthesiaNRT>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioSynesthesiaNRTClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesiaEditor.AudioSynesthesiaNRTFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AudioSynesthesiaNRTClass = 0;
	}
}