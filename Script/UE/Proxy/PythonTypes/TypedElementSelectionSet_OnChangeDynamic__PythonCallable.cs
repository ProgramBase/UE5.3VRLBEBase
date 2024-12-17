using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/TypedElementSelectionSet_OnChangeDynamic__PythonCallable.TypedElementSelectionSet_OnChangeDynamic__PythonCallable")]
	public partial class TypedElementSelectionSet_OnChangeDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/TypedElementSelectionSet_OnChangeDynamic__PythonCallable.TypedElementSelectionSet_OnChangeDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}