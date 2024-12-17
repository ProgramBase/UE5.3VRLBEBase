using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_AnimEasingType")]
	public partial class FRigVMFunction_AnimEasingType : FRigVMFunction_AnimBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_AnimEasingType");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_AnimEasingType()
		{
		}

		public static bool operator ==(FRigVMFunction_AnimEasingType A, FRigVMFunction_AnimEasingType B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_AnimEasingType A, FRigVMFunction_AnimEasingType B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_AnimEasingType;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERigVMAnimEasingType Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(ERigVMAnimEasingType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		private static uint __Type = 0;

	}
}