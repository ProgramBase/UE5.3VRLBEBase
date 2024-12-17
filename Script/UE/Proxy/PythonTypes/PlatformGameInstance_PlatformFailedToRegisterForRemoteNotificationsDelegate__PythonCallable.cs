using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PlatformGameInstance_PlatformFailedToRegisterForRemoteNotificationsDelegate__PythonCallable.PlatformGameInstance_PlatformFailedToRegisterForRemoteNotificationsDelegate__PythonCallable")]
	public partial class PlatformGameInstance_PlatformFailedToRegisterForRemoteNotificationsDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PlatformGameInstance_PlatformFailedToRegisterForRemoteNotificationsDelegate__PythonCallable.PlatformGameInstance_PlatformFailedToRegisterForRemoteNotificationsDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}