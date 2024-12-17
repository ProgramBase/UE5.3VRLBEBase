using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMControllerSettings")]
	public partial class URigVMControllerSettings : UObject, IStaticClass
	{
		public bool bAutoResolveTemplateNodesWhenLinkingExecute
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoResolveTemplateNodesWhenLinkingExecute, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoResolveTemplateNodesWhenLinkingExecute, __InBuffer);
				}
			}
		}

		public TMap<FName, FRigVMController_CommonTypePerTemplate> TemplateDefaultTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateDefaultTypes, __ReturnBuffer);

					return *(TMap<FName, FRigVMController_CommonTypePerTemplate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateDefaultTypes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMControllerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAutoResolveTemplateNodesWhenLinkingExecute = 0;

		private static uint __TemplateDefaultTypes = 0;
	}
}