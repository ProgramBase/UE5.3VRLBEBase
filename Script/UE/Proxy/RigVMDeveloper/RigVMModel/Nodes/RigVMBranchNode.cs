using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMBranchNode")]
	public partial class UDEPRECATED_RigVMBranchNode : URigVMNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMBranchNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}