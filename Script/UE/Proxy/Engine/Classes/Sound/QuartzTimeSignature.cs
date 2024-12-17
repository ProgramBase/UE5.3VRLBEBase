using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.QuartzTimeSignature")]
	public partial class FQuartzTimeSignature : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.QuartzTimeSignature");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQuartzTimeSignature() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQuartzTimeSignature() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQuartzTimeSignature A, FQuartzTimeSignature B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQuartzTimeSignature A, FQuartzTimeSignature B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQuartzTimeSignature;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumBeats
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumBeats, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumBeats, __InBuffer);
				}
			}
		}

		public EQuartzTimeSignatureQuantization BeatType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BeatType, __ReturnBuffer);

					return *(EQuartzTimeSignatureQuantization*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BeatType, __InBuffer);
				}
			}
		}

		public TArray<FQuartzPulseOverrideStep> OptionalPulseOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OptionalPulseOverride, __ReturnBuffer);

					return *(TArray<FQuartzPulseOverrideStep>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OptionalPulseOverride, __InBuffer);
				}
			}
		}

		private static uint __NumBeats = 0;

		private static uint __BeatType = 0;

		private static uint __OptionalPulseOverride = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}