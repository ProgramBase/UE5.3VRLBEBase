using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectStereoToQuadSettings")]
	public partial class FSubmixEffectStereoToQuadSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SubmixEffectStereoToQuadSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubmixEffectStereoToQuadSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubmixEffectStereoToQuadSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubmixEffectStereoToQuadSettings A, FSubmixEffectStereoToQuadSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubmixEffectStereoToQuadSettings A, FSubmixEffectStereoToQuadSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubmixEffectStereoToQuadSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bFlipChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFlipChannels, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFlipChannels, __InBuffer);
				}
			}
		}

		public float RearChannelGain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RearChannelGain, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RearChannelGain, __InBuffer);
				}
			}
		}

		private static uint __bFlipChannels = 0;

		private static uint __RearChannelGain = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}