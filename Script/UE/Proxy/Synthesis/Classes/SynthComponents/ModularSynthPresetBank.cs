using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ModularSynthPresetBank")]
	public partial class UModularSynthPresetBank : UObject, IStaticClass
	{
		public TArray<FModularSynthPresetBankEntry> Presets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Presets, __ReturnBuffer);

					return *(TArray<FModularSynthPresetBankEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Presets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.ModularSynthPresetBank");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Presets = 0;
	}
}