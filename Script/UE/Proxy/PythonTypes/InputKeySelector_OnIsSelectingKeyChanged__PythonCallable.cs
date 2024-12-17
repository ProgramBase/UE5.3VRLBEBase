using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InputKeySelector_OnIsSelectingKeyChanged__PythonCallable.InputKeySelector_OnIsSelectingKeyChanged__PythonCallable")]
	public partial class InputKeySelector_OnIsSelectingKeyChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InputKeySelector_OnIsSelectingKeyChanged__PythonCallable.InputKeySelector_OnIsSelectingKeyChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}