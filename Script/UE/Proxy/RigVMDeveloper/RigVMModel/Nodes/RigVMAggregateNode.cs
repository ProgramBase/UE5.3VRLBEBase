using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMAggregateNode")]
	public partial class URigVMAggregateNode : URigVMCollapseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMAggregateNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}