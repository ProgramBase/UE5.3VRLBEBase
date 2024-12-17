using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain")]
	public partial class FRigUnit_FitSplineCurveToChain : FRigUnit_HighlevelBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChain");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_FitSplineCurveToChain()
		{
		}

		public static bool operator ==(FRigUnit_FitSplineCurveToChain A, FRigUnit_FitSplineCurveToChain B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_FitSplineCurveToChain A, FRigUnit_FitSplineCurveToChain B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_FitSplineCurveToChain;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKeyCollection Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Items, __InBuffer);
				}
			}
		}

		public FControlRigSpline Spline
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Spline, __ReturnBuffer);

					return *(FControlRigSpline*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Spline, __InBuffer);
				}
			}
		}

		private static uint __Items = 0;

		private static uint __Spline = 0;

	}
}