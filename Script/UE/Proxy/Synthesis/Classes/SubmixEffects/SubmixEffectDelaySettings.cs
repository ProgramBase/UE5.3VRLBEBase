using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectDelaySettings")]
	public partial class FSubmixEffectDelaySettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SubmixEffectDelaySettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubmixEffectDelaySettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubmixEffectDelaySettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubmixEffectDelaySettings A, FSubmixEffectDelaySettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubmixEffectDelaySettings A, FSubmixEffectDelaySettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubmixEffectDelaySettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MaximumDelayLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaximumDelayLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaximumDelayLength, __InBuffer);
				}
			}
		}

		public float InterpolationTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationTime, __InBuffer);
				}
			}
		}

		public float DelayLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DelayLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DelayLength, __InBuffer);
				}
			}
		}

		private static uint __MaximumDelayLength = 0;

		private static uint __InterpolationTime = 0;

		private static uint __DelayLength = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}