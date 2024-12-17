using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnButtonReleasedEvent__PythonCallable.OnButtonReleasedEvent__PythonCallable")]
	public partial class OnButtonReleasedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnButtonReleasedEvent__PythonCallable.OnButtonReleasedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}