using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ApplicationLifecycleComponent_ApplicationLifetimeDelegate__PythonCallable.ApplicationLifecycleComponent_ApplicationLifetimeDelegate__PythonCallable")]
	public partial class ApplicationLifecycleComponent_ApplicationLifetimeDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ApplicationLifecycleComponent_ApplicationLifetimeDelegate__PythonCallable.ApplicationLifecycleComponent_ApplicationLifetimeDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}