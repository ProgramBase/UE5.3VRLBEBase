using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMRenameExposedPinAction")]
	public partial class FRigVMRenameExposedPinAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMRenameExposedPinAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMRenameExposedPinAction()
		{
		}

		public static bool operator ==(FRigVMRenameExposedPinAction A, FRigVMRenameExposedPinAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMRenameExposedPinAction A, FRigVMRenameExposedPinAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMRenameExposedPinAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString OldPinName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OldPinName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OldPinName, __InBuffer);
				}
			}
		}

		public FString NewPinName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewPinName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewPinName, __InBuffer);
				}
			}
		}

		private static uint __OldPinName = 0;

		private static uint __NewPinName = 0;

	}
}