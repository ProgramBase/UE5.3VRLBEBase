using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary")]
	public partial class UResonanceAudioBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetGlobalReverbPreset(UResonanceAudioReverbPluginPreset InPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetGlobalReverbPreset, __InBuffer);
			}
		}

		public static UResonanceAudioReverbPluginPreset GetGlobalReverbPreset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGlobalReverbPreset, __ReturnBuffer);

				return *(UResonanceAudioReverbPluginPreset*)__ReturnBuffer;
			}
		}

		private static uint __SetGlobalReverbPreset = 0;

		private static uint __GetGlobalReverbPreset = 0;
	}
}