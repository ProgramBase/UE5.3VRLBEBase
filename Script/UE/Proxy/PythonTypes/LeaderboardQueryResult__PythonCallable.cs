using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/LeaderboardQueryResult__PythonCallable.LeaderboardQueryResult__PythonCallable")]
	public partial class LeaderboardQueryResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/LeaderboardQueryResult__PythonCallable.LeaderboardQueryResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}