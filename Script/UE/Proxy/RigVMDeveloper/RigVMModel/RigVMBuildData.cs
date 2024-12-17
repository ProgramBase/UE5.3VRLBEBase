using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMBuildData")]
	public partial class URigVMBuildData : UObject, IStaticClass
	{
		public TMap<FRigVMGraphFunctionIdentifier, FRigVMFunctionReferenceArray> GraphFunctionReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GraphFunctionReferences, __ReturnBuffer);

					return *(TMap<FRigVMGraphFunctionIdentifier, FRigVMFunctionReferenceArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GraphFunctionReferences, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMBuildData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GraphFunctionReferences = 0;
	}
}