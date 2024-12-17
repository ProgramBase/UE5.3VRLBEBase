using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMRenameNodeAction")]
	public partial class FRigVMRenameNodeAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMRenameNodeAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMRenameNodeAction()
		{
		}

		public static bool operator ==(FRigVMRenameNodeAction A, FRigVMRenameNodeAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMRenameNodeAction A, FRigVMRenameNodeAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMRenameNodeAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString OldNodeName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OldNodeName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OldNodeName, __InBuffer);
				}
			}
		}

		public FString NewNodeName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewNodeName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewNodeName, __InBuffer);
				}
			}
		}

		private static uint __OldNodeName = 0;

		private static uint __NewNodeName = 0;

	}
}