using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnInputAction__PythonCallable.OnInputAction__PythonCallable")]
	public partial class OnInputAction__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnInputAction__PythonCallable.OnInputAction__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}