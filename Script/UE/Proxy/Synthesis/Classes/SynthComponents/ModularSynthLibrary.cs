using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ModularSynthLibrary")]
	public partial class UModularSynthLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.ModularSynthLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void AddModularSynthPresetToBankAsset(UModularSynthPresetBank InBank, FModularSynthPreset Preset, FString PresetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InBank?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Preset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PresetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddModularSynthPresetToBankAsset, __InBuffer);
			}
		}

		private static uint __AddModularSynthPresetToBankAsset = 0;
	}
}