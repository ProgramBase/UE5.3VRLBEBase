using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMExpandNodeAction")]
	public partial class FRigVMExpandNodeAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMExpandNodeAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMExpandNodeAction()
		{
		}

		public static bool operator ==(FRigVMExpandNodeAction A, FRigVMExpandNodeAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMExpandNodeAction A, FRigVMExpandNodeAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMExpandNodeAction;

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

		public FString LibraryNodeContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LibraryNodeContent, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LibraryNodeContent, __InBuffer);
				}
			}
		}

		public TArray<FString> ExpandedNodePaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpandedNodePaths, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpandedNodePaths, __InBuffer);
				}
			}
		}

		private static uint __LibraryNodePath = 0;

		private static uint __LibraryNodeContent = 0;

		private static uint __ExpandedNodePaths = 0;

	}
}