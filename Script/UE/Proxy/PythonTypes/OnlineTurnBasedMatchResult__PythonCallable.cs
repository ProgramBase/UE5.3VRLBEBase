using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnlineTurnBasedMatchResult__PythonCallable.OnlineTurnBasedMatchResult__PythonCallable")]
	public partial class OnlineTurnBasedMatchResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnlineTurnBasedMatchResult__PythonCallable.OnlineTurnBasedMatchResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}