using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMFunctionReferenceArray")]
	public partial class FRigVMFunctionReferenceArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMFunctionReferenceArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunctionReferenceArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMFunctionReferenceArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMFunctionReferenceArray A, FRigVMFunctionReferenceArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunctionReferenceArray A, FRigVMFunctionReferenceArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunctionReferenceArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> FunctionReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionReferences, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionReferences, __InBuffer);
				}
			}
		}

		private static uint __FunctionReferences = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}