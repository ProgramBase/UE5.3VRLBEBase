using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/FunctionalTestAISpawned__PythonCallable.FunctionalTestAISpawned__PythonCallable")]
	public partial class FunctionalTestAISpawned__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/FunctionalTestAISpawned__PythonCallable.FunctionalTestAISpawned__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}