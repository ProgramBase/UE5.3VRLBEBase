using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray")]
	public partial class FRigUnit_FitSplineCurveToChainItemArray : FRigUnit_HighlevelBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_FitSplineCurveToChainItemArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_FitSplineCurveToChainItemArray()
		{
		}

		public static bool operator ==(FRigUnit_FitSplineCurveToChainItemArray A, FRigUnit_FitSplineCurveToChainItemArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_FitSplineCurveToChainItemArray A, FRigUnit_FitSplineCurveToChainItemArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_FitSplineCurveToChainItemArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
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