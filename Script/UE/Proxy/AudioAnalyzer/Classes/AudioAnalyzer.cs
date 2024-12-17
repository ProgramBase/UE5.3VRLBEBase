using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioAnalyzer
{
	[PathName("/Script/AudioAnalyzer.AudioAnalyzer")]
	public partial class UAudioAnalyzer : UObject, IStaticClass
	{
		public UAudioBus AudioBus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioBus, __ReturnBuffer);

					return *(UAudioBus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioBus, __InBuffer);
				}
			}
		}

		public UAudioAnalyzerSubsystem AudioAnalyzerSubsystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioAnalyzerSubsystem, __ReturnBuffer);

					return *(UAudioAnalyzerSubsystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioAnalyzerSubsystem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioAnalyzer.AudioAnalyzer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopAnalyzing(UObject WorldContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAnalyzing, __InBuffer);
			}
		}

		public virtual void StartAnalyzing(UObject WorldContextObject, UAudioBus AudioBusToAnalyze)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AudioBusToAnalyze?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartAnalyzing, __InBuffer);
			}
		}

		private static uint __AudioBus = 0;

		private static uint __AudioAnalyzerSubsystem = 0;

		private static uint __StopAnalyzing = 0;

		private static uint __StartAnalyzing = 0;
	}
}