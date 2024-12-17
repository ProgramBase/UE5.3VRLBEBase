using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMAddLinkAction")]
	public partial class FRigVMAddLinkAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMAddLinkAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMAddLinkAction()
		{
		}

		public static bool operator ==(FRigVMAddLinkAction A, FRigVMAddLinkAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMAddLinkAction A, FRigVMAddLinkAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMAddLinkAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString OutputPinPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputPinPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputPinPath, __InBuffer);
				}
			}
		}

		public FString InputPinPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputPinPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputPinPath, __InBuffer);
				}
			}
		}

		private static uint __OutputPinPath = 0;

		private static uint __InputPinPath = 0;

	}
}