using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver")]
	public partial class FIKFootPelvisPullDownSolver : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKFootPelvisPullDownSolver() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIKFootPelvisPullDownSolver() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIKFootPelvisPullDownSolver A, FIKFootPelvisPullDownSolver B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKFootPelvisPullDownSolver A, FIKFootPelvisPullDownSolver B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKFootPelvisPullDownSolver;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVectorRK4SpringInterpolator PelvisAdjustmentInterp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentInterp, __ReturnBuffer);

					return *(FVectorRK4SpringInterpolator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentInterp, __InBuffer);
				}
			}
		}

		public double PelvisAdjustmentInterpAlpha
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentInterpAlpha, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentInterpAlpha, __InBuffer);
				}
			}
		}

		public double PelvisAdjustmentMaxDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentMaxDistance, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentMaxDistance, __InBuffer);
				}
			}
		}

		public double PelvisAdjustmentErrorTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentErrorTolerance, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentErrorTolerance, __InBuffer);
				}
			}
		}

		public int PelvisAdjustmentMaxIter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentMaxIter, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PelvisAdjustmentMaxIter, __InBuffer);
				}
			}
		}

		private static uint __PelvisAdjustmentInterp = 0;

		private static uint __PelvisAdjustmentInterpAlpha = 0;

		private static uint __PelvisAdjustmentMaxDistance = 0;

		private static uint __PelvisAdjustmentErrorTolerance = 0;

		private static uint __PelvisAdjustmentMaxIter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}