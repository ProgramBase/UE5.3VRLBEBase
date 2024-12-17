using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDeleteActorsBegin__PythonCallable.OnDeleteActorsBegin__PythonCallable")]
	public partial class OnDeleteActorsBegin__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDeleteActorsBegin__PythonCallable.OnDeleteActorsBegin__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}