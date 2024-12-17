using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMFunctionReturnNode")]
	public partial class URigVMFunctionReturnNode : URigVMTemplateNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMFunctionReturnNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}