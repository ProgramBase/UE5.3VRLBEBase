using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnRequestContentFailed__PythonCallable.OnRequestContentFailed__PythonCallable")]
	public partial class OnRequestContentFailed__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnRequestContentFailed__PythonCallable.OnRequestContentFailed__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}