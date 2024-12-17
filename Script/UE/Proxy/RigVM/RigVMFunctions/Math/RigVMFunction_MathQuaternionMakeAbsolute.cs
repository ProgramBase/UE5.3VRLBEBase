using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathQuaternionMakeAbsolute")]
	public partial class FRigVMFunction_MathQuaternionMakeAbsolute : FRigVMFunction_MathQuaternionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathQuaternionMakeAbsolute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathQuaternionMakeAbsolute()
		{
		}

		public static bool operator ==(FRigVMFunction_MathQuaternionMakeAbsolute A, FRigVMFunction_MathQuaternionMakeAbsolute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathQuaternionMakeAbsolute A, FRigVMFunction_MathQuaternionMakeAbsolute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathQuaternionMakeAbsolute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FQuat Local
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Local, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Local, __InBuffer);
				}
			}
		}

		public FQuat Parent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parent, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parent, __InBuffer);
				}
			}
		}

		public FQuat Global
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Global, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Global, __InBuffer);
				}
			}
		}

		private static uint __Local = 0;

		private static uint __Parent = 0;

		private static uint __Global = 0;

	}
}