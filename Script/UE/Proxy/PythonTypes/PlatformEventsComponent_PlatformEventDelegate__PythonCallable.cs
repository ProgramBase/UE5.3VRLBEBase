using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PlatformEventsComponent_PlatformEventDelegate__PythonCallable.PlatformEventsComponent_PlatformEventDelegate__PythonCallable")]
	public partial class PlatformEventsComponent_PlatformEventDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PlatformEventsComponent_PlatformEventDelegate__PythonCallable.PlatformEventsComponent_PlatformEventDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}