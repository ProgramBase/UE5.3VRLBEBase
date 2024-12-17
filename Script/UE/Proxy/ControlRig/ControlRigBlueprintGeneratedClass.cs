using Script.CoreUObject;
using Script.RigVM;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigBlueprintGeneratedClass")]
	public partial class UControlRigBlueprintGeneratedClass : URigVMBlueprintGeneratedClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigBlueprintGeneratedClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}