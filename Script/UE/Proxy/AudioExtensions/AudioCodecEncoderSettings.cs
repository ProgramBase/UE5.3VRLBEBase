using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.AudioCodecEncoderSettings")]
	public partial class UAudioCodecEncoderSettings : UObject, IStaticClass
	{
		public int Version
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Version, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Version, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.AudioCodecEncoderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Version = 0;
	}
}