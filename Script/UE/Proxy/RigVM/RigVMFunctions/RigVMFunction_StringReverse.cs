using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_StringReverse")]
	public partial class FRigVMFunction_StringReverse : FRigVMFunction_StringBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_StringReverse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_StringReverse()
		{
		}

		public static bool operator ==(FRigVMFunction_StringReverse A, FRigVMFunction_StringReverse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_StringReverse A, FRigVMFunction_StringReverse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_StringReverse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public FString Reverse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Reverse, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Reverse, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __Reverse = 0;

	}
}