using Script.CoreUObject;
using Script.RigVMDeveloper;
using Script.Library;

namespace Script.ControlRigDeveloper
{
	[PathName("/Script/ControlRigDeveloper.ControlRigGraph")]
	public partial class UControlRigGraph : URigVMEdGraph, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigDeveloper.ControlRigGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}