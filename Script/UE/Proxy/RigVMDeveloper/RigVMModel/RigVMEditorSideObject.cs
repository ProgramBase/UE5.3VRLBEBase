using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEditorSideObject")]
	public partial class URigVMEditorSideObject : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMEditorSideObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/RigVMDeveloper.RigVMEditorSideObject")]
	public interface IRigVMEditorSideObject : IInterface
	{
	}
}