using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditCopyActorsBegin__PythonCallable.OnEditCopyActorsBegin__PythonCallable")]
	public partial class OnEditCopyActorsBegin__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditCopyActorsBegin__PythonCallable.OnEditCopyActorsBegin__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}