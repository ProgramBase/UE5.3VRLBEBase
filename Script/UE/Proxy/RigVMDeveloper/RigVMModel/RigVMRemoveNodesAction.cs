using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMRemoveNodesAction")]
	public partial class FRigVMRemoveNodesAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMRemoveNodesAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMRemoveNodesAction()
		{
		}

		public static bool operator ==(FRigVMRemoveNodesAction A, FRigVMRemoveNodesAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMRemoveNodesAction A, FRigVMRemoveNodesAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMRemoveNodesAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> NodeNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeNames, __InBuffer);
				}
			}
		}

		public FString ExportedContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExportedContent, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExportedContent, __InBuffer);
				}
			}
		}

		private static uint __NodeNames = 0;

		private static uint __ExportedContent = 0;

	}
}