using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectTapDelaySettings")]
	public partial class FSubmixEffectTapDelaySettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SubmixEffectTapDelaySettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubmixEffectTapDelaySettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubmixEffectTapDelaySettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubmixEffectTapDelaySettings A, FSubmixEffectTapDelaySettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubmixEffectTapDelaySettings A, FSubmixEffectTapDelaySettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubmixEffectTapDelaySettings;

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

		public TArray<FTapDelayInfo> Taps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Taps, __ReturnBuffer);

					return *(TArray<FTapDelayInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Taps, __InBuffer);
				}
			}
		}

		private static uint __MaximumDelayLength = 0;

		private static uint __InterpolationTime = 0;

		private static uint __Taps = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}