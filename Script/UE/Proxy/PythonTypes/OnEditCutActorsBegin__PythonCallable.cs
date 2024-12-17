using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditCutActorsBegin__PythonCallable.OnEditCutActorsBegin__PythonCallable")]
	public partial class OnEditCutActorsBegin__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditCutActorsBegin__PythonCallable.OnEditCutActorsBegin__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}