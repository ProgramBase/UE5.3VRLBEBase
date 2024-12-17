using Script.CoreUObject;
using Script.RigVMDeveloper;
using Script.Library;

namespace Script.ControlRigDeveloper
{
	[PathName("/Script/ControlRigDeveloper.ControlRigSchema")]
	public partial class UControlRigSchema : URigVMSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigDeveloper.ControlRigSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}