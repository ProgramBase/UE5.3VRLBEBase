using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.TargetPlatformRegister")]
	public partial class UTargetPlatformRegister : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.TargetPlatformRegister");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}