using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComboBoxKey_OnOpeningEvent__PythonCallable.ComboBoxKey_OnOpeningEvent__PythonCallable")]
	public partial class ComboBoxKey_OnOpeningEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComboBoxKey_OnOpeningEvent__PythonCallable.ComboBoxKey_OnOpeningEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}