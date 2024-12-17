using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PlatformGameInstance_PlatformReceivedLocalNotificationDelegate__PythonCallable.PlatformGameInstance_PlatformReceivedLocalNotificationDelegate__PythonCallable")]
	public partial class PlatformGameInstance_PlatformReceivedLocalNotificationDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PlatformGameInstance_PlatformReceivedLocalNotificationDelegate__PythonCallable.PlatformGameInstance_PlatformReceivedLocalNotificationDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}