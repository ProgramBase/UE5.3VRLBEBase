using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathQuaternionRotationOrder")]
	public partial class FRigVMFunction_MathQuaternionRotationOrder : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathQuaternionRotationOrder");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathQuaternionRotationOrder()
		{
		}

		public static bool operator ==(FRigVMFunction_MathQuaternionRotationOrder A, FRigVMFunction_MathQuaternionRotationOrder B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathQuaternionRotationOrder A, FRigVMFunction_MathQuaternionRotationOrder B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathQuaternionRotationOrder;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EEulerRotationOrder RotationOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RotationOrder, __ReturnBuffer);

					return *(EEulerRotationOrder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RotationOrder, __InBuffer);
				}
			}
		}

		private static uint __RotationOrder = 0;

	}
}