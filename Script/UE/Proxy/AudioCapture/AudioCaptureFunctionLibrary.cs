using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioCapture
{
	[PathName("/Script/AudioCapture.AudioCaptureFunctionLibrary")]
	public partial class UAudioCaptureFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioCapture.AudioCaptureFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAudioCapture CreateAudioCapture()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __CreateAudioCapture, __ReturnBuffer);

				return *(UAudioCapture*)__ReturnBuffer;
			}
		}

		private static uint __CreateAudioCapture = 0;
	}
}