using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMClientHost")]
	public partial class URigVMClientHost : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMClientHost");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/RigVMDeveloper.RigVMClientHost")]
	public interface IRigVMClientHost : IInterface
	{
	}
}