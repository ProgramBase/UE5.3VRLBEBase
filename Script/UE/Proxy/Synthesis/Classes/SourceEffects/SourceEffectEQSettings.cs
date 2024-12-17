using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectEQSettings")]
	public partial class FSourceEffectEQSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectEQSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectEQSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectEQSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectEQSettings A, FSourceEffectEQSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectEQSettings A, FSourceEffectEQSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectEQSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSourceEffectEQBand> EQBands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EQBands, __ReturnBuffer);

					return *(TArray<FSourceEffectEQBand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EQBands, __InBuffer);
				}
			}
		}

		private static uint __EQBands = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}