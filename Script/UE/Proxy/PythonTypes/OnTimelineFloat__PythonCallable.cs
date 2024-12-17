using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTimelineFloat__PythonCallable.OnTimelineFloat__PythonCallable")]
	public partial class OnTimelineFloat__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTimelineFloat__PythonCallable.OnTimelineFloat__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}