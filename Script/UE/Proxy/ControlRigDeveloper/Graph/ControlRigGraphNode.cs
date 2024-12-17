using Script.CoreUObject;
using Script.RigVMDeveloper;
using Script.Library;

namespace Script.ControlRigDeveloper
{
	[PathName("/Script/ControlRigDeveloper.ControlRigGraphNode")]
	public partial class UControlRigGraphNode : URigVMEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigDeveloper.ControlRigGraphNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}