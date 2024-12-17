using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMGraphFunctionIdentifier")]
	public partial class FRigVMGraphFunctionIdentifier : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMGraphFunctionIdentifier");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMGraphFunctionIdentifier() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMGraphFunctionIdentifier() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMGraphFunctionIdentifier A, FRigVMGraphFunctionIdentifier B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMGraphFunctionIdentifier A, FRigVMGraphFunctionIdentifier B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMGraphFunctionIdentifier;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath LibraryNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LibraryNode, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LibraryNode, __InBuffer);
				}
			}
		}

		public FSoftObjectPath HostObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HostObject, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HostObject, __InBuffer);
				}
			}
		}

		private static uint __LibraryNode = 0;

		private static uint __HostObject = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}