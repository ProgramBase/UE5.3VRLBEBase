using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComboBoxString_OnSelectionChangedEvent__PythonCallable.ComboBoxString_OnSelectionChangedEvent__PythonCallable")]
	public partial class ComboBoxString_OnSelectionChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComboBoxString_OnSelectionChangedEvent__PythonCallable.ComboBoxString_OnSelectionChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}