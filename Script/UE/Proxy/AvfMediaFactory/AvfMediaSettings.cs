using Script.CoreUObject;
using Script.Library;

namespace Script.AvfMediaFactory
{
	[PathName("/Script/AvfMediaFactory.AvfMediaSettings")]
	public partial class UAvfMediaSettings : UObject, IStaticClass
	{
		public bool NativeAudioOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NativeAudioOut, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NativeAudioOut, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AvfMediaFactory.AvfMediaSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NativeAudioOut = 0;
	}
}