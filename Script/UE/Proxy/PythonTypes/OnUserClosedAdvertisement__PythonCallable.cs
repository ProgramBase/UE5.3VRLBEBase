using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnUserClosedAdvertisement__PythonCallable.OnUserClosedAdvertisement__PythonCallable")]
	public partial class OnUserClosedAdvertisement__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnUserClosedAdvertisement__PythonCallable.OnUserClosedAdvertisement__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}