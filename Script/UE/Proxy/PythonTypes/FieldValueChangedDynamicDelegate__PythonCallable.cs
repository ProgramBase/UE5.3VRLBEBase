using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/FieldValueChangedDynamicDelegate__PythonCallable.FieldValueChangedDynamicDelegate__PythonCallable")]
	public partial class FieldValueChangedDynamicDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/FieldValueChangedDynamicDelegate__PythonCallable.FieldValueChangedDynamicDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}