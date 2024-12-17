using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMGraphFunctionHost")]
	public partial class URigVMGraphFunctionHost : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMGraphFunctionHost");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/RigVM.RigVMGraphFunctionHost")]
	public interface IRigVMGraphFunctionHost : IInterface
	{
	}
}