using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioAnalyzer
{
	[PathName("/Script/AudioAnalyzer.AudioAnalyzerNRT")]
	public partial class UAudioAnalyzerNRT : UAudioAnalyzerAssetBase, IStaticClass
	{
		public USoundWave Sound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sound, __ReturnBuffer);

					return *(USoundWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sound, __InBuffer);
				}
			}
		}

		public float DurationInSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DurationInSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DurationInSeconds, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioAnalyzer.AudioAnalyzerNRT");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void AnalyzeAudio()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AnalyzeAudio);
			}
		}

		private static uint __Sound = 0;

		private static uint __DurationInSeconds = 0;

		private static uint __AnalyzeAudio = 0;
	}
}