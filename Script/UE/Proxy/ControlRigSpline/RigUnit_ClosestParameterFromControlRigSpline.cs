using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline")]
	public partial class FRigUnit_ClosestParameterFromControlRigSpline : FRigUnit_ControlRigSplineBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_ClosestParameterFromControlRigSpline");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ClosestParameterFromControlRigSpline()
		{
		}

		public static bool operator ==(FRigUnit_ClosestParameterFromControlRigSpline A, FRigUnit_ClosestParameterFromControlRigSpline B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ClosestParameterFromControlRigSpline A, FRigUnit_ClosestParameterFromControlRigSpline B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ClosestParameterFromControlRigSpline;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public FVector Position
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Position, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Position, __InBuffer);
				}
			}
		}

		public float U
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __U, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __U, __InBuffer);
				}
			}
		}

		private static uint __Spline = 0;

		private static uint __Position = 0;

		private static uint __U = 0;

	}
}