using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HapticFeedbackDetails_Curve")]
	public partial class FHapticFeedbackDetails_Curve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.HapticFeedbackDetails_Curve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHapticFeedbackDetails_Curve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FHapticFeedbackDetails_Curve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FHapticFeedbackDetails_Curve A, FHapticFeedbackDetails_Curve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHapticFeedbackDetails_Curve A, FHapticFeedbackDetails_Curve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHapticFeedbackDetails_Curve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRuntimeFloatCurve Frequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __ReturnBuffer);

					return *(FRuntimeFloatCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __InBuffer);
				}
			}
		}

		public FRuntimeFloatCurve Amplitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Amplitude, __ReturnBuffer);

					return *(FRuntimeFloatCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Amplitude, __InBuffer);
				}
			}
		}

		private static uint __Frequency = 0;

		private static uint __Amplitude = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}