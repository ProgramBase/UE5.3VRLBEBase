using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PlatformGameInstance_PlatformRegisteredForRemoteNotificationsDelegate__PythonCallable.PlatformGameInstance_PlatformRegisteredForRemoteNotificationsDelegate__PythonCallable")]
	public partial class PlatformGameInstance_PlatformRegisteredForRemoteNotificationsDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PlatformGameInstance_PlatformRegisteredForRemoteNotificationsDelegate__PythonCallable.PlatformGameInstance_PlatformRegisteredForRemoteNotificationsDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}