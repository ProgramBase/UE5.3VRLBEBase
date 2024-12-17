using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMMarkFunctionPublicAction")]
	public partial class FRigVMMarkFunctionPublicAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMMarkFunctionPublicAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMMarkFunctionPublicAction()
		{
		}

		public static bool operator ==(FRigVMMarkFunctionPublicAction A, FRigVMMarkFunctionPublicAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMMarkFunctionPublicAction A, FRigVMMarkFunctionPublicAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMMarkFunctionPublicAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName FunctionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionName, __InBuffer);
				}
			}
		}

		public bool bIsPublic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPublic, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPublic, __InBuffer);
				}
			}
		}

		private static uint __FunctionName = 0;

		private static uint __bIsPublic = 0;

	}
}