using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMSelectNode")]
	public partial class UDEPRECATED_RigVMSelectNode : URigVMTemplateNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMSelectNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}