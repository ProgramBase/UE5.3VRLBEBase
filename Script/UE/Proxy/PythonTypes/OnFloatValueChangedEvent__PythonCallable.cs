using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnFloatValueChangedEvent__PythonCallable.OnFloatValueChangedEvent__PythonCallable")]
	public partial class OnFloatValueChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnFloatValueChangedEvent__PythonCallable.OnFloatValueChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}