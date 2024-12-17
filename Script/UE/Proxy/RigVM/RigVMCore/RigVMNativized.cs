using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMNativized")]
	public partial class URigVMNativized : URigVM, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMNativized");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}