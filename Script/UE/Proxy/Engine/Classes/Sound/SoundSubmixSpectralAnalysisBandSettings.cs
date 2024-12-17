using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings")]
	public partial class FSoundSubmixSpectralAnalysisBandSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundSubmixSpectralAnalysisBandSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoundSubmixSpectralAnalysisBandSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoundSubmixSpectralAnalysisBandSettings A, FSoundSubmixSpectralAnalysisBandSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundSubmixSpectralAnalysisBandSettings A, FSoundSubmixSpectralAnalysisBandSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundSubmixSpectralAnalysisBandSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float BandFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BandFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BandFrequency, __InBuffer);
				}
			}
		}

		public int AttackTimeMsec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttackTimeMsec, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttackTimeMsec, __InBuffer);
				}
			}
		}

		public int ReleaseTimeMsec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReleaseTimeMsec, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReleaseTimeMsec, __InBuffer);
				}
			}
		}

		public float QFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QFactor, __InBuffer);
				}
			}
		}

		private static uint __BandFrequency = 0;

		private static uint __AttackTimeMsec = 0;

		private static uint __ReleaseTimeMsec = 0;

		private static uint __QFactor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}