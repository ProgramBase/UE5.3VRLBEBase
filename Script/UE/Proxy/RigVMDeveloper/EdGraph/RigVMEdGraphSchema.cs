using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphSchema")]
	public partial class URigVMEdGraphSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMEdGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}