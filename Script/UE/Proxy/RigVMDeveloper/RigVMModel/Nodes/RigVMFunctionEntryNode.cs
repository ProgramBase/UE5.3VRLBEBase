using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMFunctionEntryNode")]
	public partial class URigVMFunctionEntryNode : URigVMTemplateNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMFunctionEntryNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}