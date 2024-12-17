using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTimelineVector__PythonCallable.OnTimelineVector__PythonCallable")]
	public partial class OnTimelineVector__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTimelineVector__PythonCallable.OnTimelineVector__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}