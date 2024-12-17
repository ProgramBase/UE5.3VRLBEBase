using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPropertyValueChanged__PythonCallable.OnPropertyValueChanged__PythonCallable")]
	public partial class OnPropertyValueChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPropertyValueChanged__PythonCallable.OnPropertyValueChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}