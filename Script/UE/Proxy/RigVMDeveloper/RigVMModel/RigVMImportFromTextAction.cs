using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMImportFromTextAction")]
	public partial class FRigVMImportFromTextAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMImportFromTextAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMImportFromTextAction()
		{
		}

		public static bool operator ==(FRigVMImportFromTextAction A, FRigVMImportFromTextAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMImportFromTextAction A, FRigVMImportFromTextAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMImportFromTextAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Content
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Content, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Content, __InBuffer);
				}
			}
		}

		public TArray<FName> TopLevelNodeNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TopLevelNodeNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TopLevelNodeNames, __InBuffer);
				}
			}
		}

		private static uint __Content = 0;

		private static uint __TopLevelNodeNames = 0;

	}
}