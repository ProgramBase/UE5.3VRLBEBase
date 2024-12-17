using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorArraySum")]
	public partial class FRigVMFunction_MathVectorArraySum : FRigVMFunction_MathVectorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorArraySum");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorArraySum()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorArraySum A, FRigVMFunction_MathVectorArraySum B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorArraySum A, FRigVMFunction_MathVectorArraySum B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorArraySum;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FVector> Array
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Array, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Array, __InBuffer);
				}
			}
		}

		public FVector Sum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sum, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sum, __InBuffer);
				}
			}
		}

		private static uint __Array = 0;

		private static uint __Sum = 0;

	}
}