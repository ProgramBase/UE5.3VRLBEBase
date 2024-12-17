using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.SynesthesiaSpectrumResults")]
	public partial class FSynesthesiaSpectrumResults : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioSynesthesia.SynesthesiaSpectrumResults");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSynesthesiaSpectrumResults() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSynesthesiaSpectrumResults() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSynesthesiaSpectrumResults A, FSynesthesiaSpectrumResults B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSynesthesiaSpectrumResults A, FSynesthesiaSpectrumResults B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSynesthesiaSpectrumResults;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float TimeSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeSeconds, __InBuffer);
				}
			}
		}

		public TArray<float> SpectrumValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpectrumValues, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpectrumValues, __InBuffer);
				}
			}
		}

		private static uint __TimeSeconds = 0;

		private static uint __SpectrumValues = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}