using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSystemFinished__PythonCallable.OnSystemFinished__PythonCallable")]
	public partial class OnSystemFinished__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSystemFinished__PythonCallable.OnSystemFinished__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}