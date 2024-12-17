using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnForceFeedbackFinished__PythonCallable.OnForceFeedbackFinished__PythonCallable")]
	public partial class OnForceFeedbackFinished__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnForceFeedbackFinished__PythonCallable.OnForceFeedbackFinished__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}