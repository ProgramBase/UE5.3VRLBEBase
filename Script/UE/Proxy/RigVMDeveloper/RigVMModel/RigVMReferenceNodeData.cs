using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMReferenceNodeData")]
	public partial class FRigVMReferenceNodeData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMReferenceNodeData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMReferenceNodeData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMReferenceNodeData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMReferenceNodeData A, FRigVMReferenceNodeData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMReferenceNodeData A, FRigVMReferenceNodeData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMReferenceNodeData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ReferenceNodePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferenceNodePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferenceNodePath, __InBuffer);
				}
			}
		}

		public FRigVMGraphFunctionIdentifier ReferencedFunctionIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedFunctionIdentifier, __ReturnBuffer);

					return *(FRigVMGraphFunctionIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedFunctionIdentifier, __InBuffer);
				}
			}
		}

		private static uint __ReferenceNodePath = 0;

		private static uint __ReferencedFunctionIdentifier = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}