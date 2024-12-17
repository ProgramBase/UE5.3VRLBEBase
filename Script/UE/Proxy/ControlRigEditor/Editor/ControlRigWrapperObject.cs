using Script.CoreUObject;
using Script.RigVMEditor;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigWrapperObject")]
	public partial class UControlRigWrapperObject : URigVMDetailsViewWrapperObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigWrapperObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}