using Script.CoreUObject;
using Script.RigVMDeveloper;
using Script.Library;

namespace Script.ControlRigDeveloper
{
	[PathName("/Script/ControlRigDeveloper.ControlRigGraphSchema")]
	public partial class UControlRigGraphSchema : URigVMEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigDeveloper.ControlRigGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}