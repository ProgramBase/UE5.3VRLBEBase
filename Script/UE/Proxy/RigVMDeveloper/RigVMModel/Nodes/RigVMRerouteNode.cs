using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMRerouteNode")]
	public partial class URigVMRerouteNode : URigVMNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMRerouteNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}