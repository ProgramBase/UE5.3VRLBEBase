using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.EpicSynth1Patch")]
	public partial class FEpicSynth1Patch : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.EpicSynth1Patch");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEpicSynth1Patch() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEpicSynth1Patch() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEpicSynth1Patch A, FEpicSynth1Patch B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEpicSynth1Patch A, FEpicSynth1Patch B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEpicSynth1Patch;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESynth1PatchSource PatchSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PatchSource, __ReturnBuffer);

					return *(ESynth1PatchSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PatchSource, __InBuffer);
				}
			}
		}

		public TArray<FSynth1PatchCable> PatchCables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PatchCables, __ReturnBuffer);

					return *(TArray<FSynth1PatchCable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PatchCables, __InBuffer);
				}
			}
		}

		private static uint __PatchSource = 0;

		private static uint __PatchCables = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}