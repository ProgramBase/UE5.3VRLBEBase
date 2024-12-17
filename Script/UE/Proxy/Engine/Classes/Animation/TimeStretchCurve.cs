using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TimeStretchCurve")]
	public partial class FTimeStretchCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TimeStretchCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimeStretchCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimeStretchCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimeStretchCurve A, FTimeStretchCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimeStretchCurve A, FTimeStretchCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimeStretchCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float SamplingRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SamplingRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SamplingRate, __InBuffer);
				}
			}
		}

		public float CurveValueMinPrecision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveValueMinPrecision, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveValueMinPrecision, __InBuffer);
				}
			}
		}

		public TArray<FTimeStretchCurveMarker> Markers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Markers, __ReturnBuffer);

					return *(TArray<FTimeStretchCurveMarker>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Markers, __InBuffer);
				}
			}
		}

		public float Sum_dT_i_by_C_i
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sum_dT_i_by_C_i, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sum_dT_i_by_C_i, __InBuffer);
				}
			}
		}

		private static uint __SamplingRate = 0;

		private static uint __CurveValueMinPrecision = 0;

		private static uint __Markers = 0;

		private static uint __Sum_dT_i_by_C_i = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}