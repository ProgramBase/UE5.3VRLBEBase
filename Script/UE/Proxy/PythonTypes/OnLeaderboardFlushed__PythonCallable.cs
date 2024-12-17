using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLeaderboardFlushed__PythonCallable.OnLeaderboardFlushed__PythonCallable")]
	public partial class OnLeaderboardFlushed__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLeaderboardFlushed__PythonCallable.OnLeaderboardFlushed__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}