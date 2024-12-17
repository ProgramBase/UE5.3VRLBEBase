using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PostEvaluateAnimEvent__PythonCallable.PostEvaluateAnimEvent__PythonCallable")]
	public partial class PostEvaluateAnimEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PostEvaluateAnimEvent__PythonCallable.PostEvaluateAnimEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}