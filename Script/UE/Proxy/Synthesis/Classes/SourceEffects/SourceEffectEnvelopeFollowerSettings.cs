using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings")]
	public partial class FSourceEffectEnvelopeFollowerSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectEnvelopeFollowerSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectEnvelopeFollowerSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectEnvelopeFollowerSettings A, FSourceEffectEnvelopeFollowerSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectEnvelopeFollowerSettings A, FSourceEffectEnvelopeFollowerSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectEnvelopeFollowerSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float AttackTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttackTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttackTime, __InBuffer);
				}
			}
		}

		public float ReleaseTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReleaseTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReleaseTime, __InBuffer);
				}
			}
		}

		public EEnvelopeFollowerPeakMode PeakMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PeakMode, __ReturnBuffer);

					return *(EEnvelopeFollowerPeakMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PeakMode, __InBuffer);
				}
			}
		}

		public bool bIsAnalogMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsAnalogMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsAnalogMode, __InBuffer);
				}
			}
		}

		private static uint __AttackTime = 0;

		private static uint __ReleaseTime = 0;

		private static uint __PeakMode = 0;

		private static uint __bIsAnalogMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}