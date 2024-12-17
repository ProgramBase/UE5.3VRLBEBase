using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMMemoryStorageGeneratorClass")]
	public partial class URigVMMemoryStorageGeneratorClass : UClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMMemoryStorageGeneratorClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}