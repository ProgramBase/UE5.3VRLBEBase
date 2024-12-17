using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage")]
	public partial class FRigUnit_ParameterAtPercentage : FRigUnit_ControlRigSplineBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ParameterAtPercentage()
		{
		}

		public static bool operator ==(FRigUnit_ParameterAtPercentage A, FRigUnit_ParameterAtPercentage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ParameterAtPercentage A, FRigUnit_ParameterAtPercentage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ParameterAtPercentage;

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

		public float Percentage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Percentage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Percentage, __InBuffer);
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

		private static uint __Percentage = 0;

		private static uint __U = 0;

	}
}