using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/TypedElementSelectionSet_OnPreChangeDynamic__PythonCallable.TypedElementSelectionSet_OnPreChangeDynamic__PythonCallable")]
	public partial class TypedElementSelectionSet_OnPreChangeDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/TypedElementSelectionSet_OnPreChangeDynamic__PythonCallable.TypedElementSelectionSet_OnPreChangeDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}