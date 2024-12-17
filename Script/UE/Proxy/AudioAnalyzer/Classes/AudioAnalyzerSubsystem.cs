using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioAnalyzer
{
	[PathName("/Script/AudioAnalyzer.AudioAnalyzerSubsystem")]
	public partial class UAudioAnalyzerSubsystem : UEngineSubsystem, IStaticClass
	{
		public TArray<UAudioAnalyzer> AudioAnalyzers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioAnalyzers, __ReturnBuffer);

					return *(TArray<UAudioAnalyzer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioAnalyzers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioAnalyzer.AudioAnalyzerSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AudioAnalyzers = 0;
	}
}