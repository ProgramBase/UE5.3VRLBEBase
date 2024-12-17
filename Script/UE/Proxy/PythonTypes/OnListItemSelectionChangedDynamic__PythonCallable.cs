using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListItemSelectionChangedDynamic__PythonCallable.OnListItemSelectionChangedDynamic__PythonCallable")]
	public partial class OnListItemSelectionChangedDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListItemSelectionChangedDynamic__PythonCallable.OnListItemSelectionChangedDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}