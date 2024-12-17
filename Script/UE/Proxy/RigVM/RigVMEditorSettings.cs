using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMEditorSettings")]
	public partial class URigVMEditorSettings : UDeveloperSettings, IStaticClass
	{
		public bool bAutoLinkMutableNodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoLinkMutableNodes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoLinkMutableNodes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAutoLinkMutableNodes = 0;
	}
}