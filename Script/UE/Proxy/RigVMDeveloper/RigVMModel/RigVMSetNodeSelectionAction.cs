using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMSetNodeSelectionAction")]
	public partial class FRigVMSetNodeSelectionAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMSetNodeSelectionAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMSetNodeSelectionAction()
		{
		}

		public static bool operator ==(FRigVMSetNodeSelectionAction A, FRigVMSetNodeSelectionAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMSetNodeSelectionAction A, FRigVMSetNodeSelectionAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMSetNodeSelectionAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> NewSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewSelection, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewSelection, __InBuffer);
				}
			}
		}

		public TArray<FName> OldSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OldSelection, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OldSelection, __InBuffer);
				}
			}
		}

		private static uint __NewSelection = 0;

		private static uint __OldSelection = 0;

	}
}