using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ModularSynthPresetBankEntry")]
	public partial class FModularSynthPresetBankEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.ModularSynthPresetBankEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FModularSynthPresetBankEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FModularSynthPresetBankEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FModularSynthPresetBankEntry A, FModularSynthPresetBankEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FModularSynthPresetBankEntry A, FModularSynthPresetBankEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FModularSynthPresetBankEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString PresetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PresetName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PresetName, __InBuffer);
				}
			}
		}

		public FModularSynthPreset Preset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Preset, __ReturnBuffer);

					return *(FModularSynthPreset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Preset, __InBuffer);
				}
			}
		}

		private static uint __PresetName = 0;

		private static uint __Preset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}