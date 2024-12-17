using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioBus")]
	public partial class UAudioBus : UObject, IStaticClass
	{
		public EAudioBusChannels AudioBusChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioBusChannels, __ReturnBuffer);

					return *(EAudioBusChannels*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioBusChannels, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioBus");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AudioBusChannels = 0;
	}
}