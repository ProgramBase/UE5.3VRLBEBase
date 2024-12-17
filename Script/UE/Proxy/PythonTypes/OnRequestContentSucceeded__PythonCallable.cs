using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnRequestContentSucceeded__PythonCallable.OnRequestContentSucceeded__PythonCallable")]
	public partial class OnRequestContentSucceeded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnRequestContentSucceeded__PythonCallable.OnRequestContentSucceeded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}