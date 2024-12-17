using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMPromoteNodeAction")]
	public partial class FRigVMPromoteNodeAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMPromoteNodeAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMPromoteNodeAction()
		{
		}

		public static bool operator ==(FRigVMPromoteNodeAction A, FRigVMPromoteNodeAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMPromoteNodeAction A, FRigVMPromoteNodeAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMPromoteNodeAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString LibraryNodePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LibraryNodePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LibraryNodePath, __InBuffer);
				}
			}
		}

		public FString FunctionDefinitionPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionDefinitionPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionDefinitionPath, __InBuffer);
				}
			}
		}

		public bool bFromFunctionToCollapseNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFromFunctionToCollapseNode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFromFunctionToCollapseNode, __InBuffer);
				}
			}
		}

		private static uint __LibraryNodePath = 0;

		private static uint __FunctionDefinitionPath = 0;

		private static uint __bFromFunctionToCollapseNode = 0;

	}
}