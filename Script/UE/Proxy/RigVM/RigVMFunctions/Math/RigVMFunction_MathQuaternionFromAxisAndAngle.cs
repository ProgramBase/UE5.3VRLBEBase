using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathQuaternionFromAxisAndAngle")]
	public partial class FRigVMFunction_MathQuaternionFromAxisAndAngle : FRigVMFunction_MathQuaternionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathQuaternionFromAxisAndAngle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathQuaternionFromAxisAndAngle()
		{
		}

		public static bool operator ==(FRigVMFunction_MathQuaternionFromAxisAndAngle A, FRigVMFunction_MathQuaternionFromAxisAndAngle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathQuaternionFromAxisAndAngle A, FRigVMFunction_MathQuaternionFromAxisAndAngle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathQuaternionFromAxisAndAngle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Axis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Axis, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Axis, __InBuffer);
				}
			}
		}

		public float Angle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Angle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Angle, __InBuffer);
				}
			}
		}

		public FQuat Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __Axis = 0;

		private static uint __Angle = 0;

		private static uint __Result = 0;

	}
}