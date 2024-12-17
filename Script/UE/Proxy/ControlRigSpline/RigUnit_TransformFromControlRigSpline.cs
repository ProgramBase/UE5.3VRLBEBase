using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline")]
	public partial class FRigUnit_TransformFromControlRigSpline : FRigUnit_ControlRigSplineBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_TransformFromControlRigSpline");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_TransformFromControlRigSpline()
		{
		}

		public static bool operator ==(FRigUnit_TransformFromControlRigSpline A, FRigUnit_TransformFromControlRigSpline B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_TransformFromControlRigSpline A, FRigUnit_TransformFromControlRigSpline B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_TransformFromControlRigSpline;

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

		public FVector UpVector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpVector, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpVector, __InBuffer);
				}
			}
		}

		public float Roll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Roll, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Roll, __InBuffer);
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

		public FTransform Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		private static uint __Spline = 0;

		private static uint __UpVector = 0;

		private static uint __Roll = 0;

		private static uint __U = 0;

		private static uint __Transform = 0;

	}
}