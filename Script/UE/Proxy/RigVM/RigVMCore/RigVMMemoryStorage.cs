using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMMemoryStorage")]
	public partial class URigVMMemoryStorage : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMMemoryStorage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}