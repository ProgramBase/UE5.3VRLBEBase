using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.PerlinNoiseShaker")]
	public partial class FPerlinNoiseShaker : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayCameras.PerlinNoiseShaker");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerlinNoiseShaker() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerlinNoiseShaker() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerlinNoiseShaker A, FPerlinNoiseShaker B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerlinNoiseShaker A, FPerlinNoiseShaker B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerlinNoiseShaker;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Amplitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Amplitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Amplitude, __InBuffer);
				}
			}
		}

		public float Frequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __InBuffer);
				}
			}
		}

		private static uint __Amplitude = 0;

		private static uint __Frequency = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}