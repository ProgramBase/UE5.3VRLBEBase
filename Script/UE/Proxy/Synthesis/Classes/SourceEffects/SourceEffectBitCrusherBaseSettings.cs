using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectBitCrusherBaseSettings")]
	public partial class FSourceEffectBitCrusherBaseSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectBitCrusherBaseSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectBitCrusherBaseSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectBitCrusherBaseSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectBitCrusherBaseSettings A, FSourceEffectBitCrusherBaseSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectBitCrusherBaseSettings A, FSourceEffectBitCrusherBaseSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectBitCrusherBaseSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float SampleRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SampleRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SampleRate, __InBuffer);
				}
			}
		}

		public float BitDepth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BitDepth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BitDepth, __InBuffer);
				}
			}
		}

		private static uint __SampleRate = 0;

		private static uint __BitDepth = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}