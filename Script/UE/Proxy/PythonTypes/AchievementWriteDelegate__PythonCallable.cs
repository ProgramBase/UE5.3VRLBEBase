using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AchievementWriteDelegate__PythonCallable.AchievementWriteDelegate__PythonCallable")]
	public partial class AchievementWriteDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AchievementWriteDelegate__PythonCallable.AchievementWriteDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}