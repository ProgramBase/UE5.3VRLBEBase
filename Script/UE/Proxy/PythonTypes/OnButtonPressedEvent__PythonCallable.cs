using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnButtonPressedEvent__PythonCallable.OnButtonPressedEvent__PythonCallable")]
	public partial class OnButtonPressedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnButtonPressedEvent__PythonCallable.OnButtonPressedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}