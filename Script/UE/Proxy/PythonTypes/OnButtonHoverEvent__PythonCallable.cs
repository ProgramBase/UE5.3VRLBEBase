using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnButtonHoverEvent__PythonCallable.OnButtonHoverEvent__PythonCallable")]
	public partial class OnButtonHoverEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnButtonHoverEvent__PythonCallable.OnButtonHoverEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}