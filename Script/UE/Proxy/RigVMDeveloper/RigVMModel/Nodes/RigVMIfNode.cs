using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMIfNode")]
	public partial class UDEPRECATED_RigVMIfNode : URigVMTemplateNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMIfNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}