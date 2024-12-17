using Script.CoreUObject;
using Script.AudioMixer;
using Script.Library;

namespace Script.AudioCapture
{
	[PathName("/Script/AudioCapture.AudioCaptureComponent")]
	public partial class UAudioCaptureComponent : USynthComponent, IStaticClass
	{
		public int JitterLatencyFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JitterLatencyFrames, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JitterLatencyFrames, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioCapture.AudioCaptureComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __JitterLatencyFrames = 0;
	}
}