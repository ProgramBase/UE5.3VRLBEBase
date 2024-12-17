using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTimelineEvent__PythonCallable.OnTimelineEvent__PythonCallable")]
	public partial class OnTimelineEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTimelineEvent__PythonCallable.OnTimelineEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}