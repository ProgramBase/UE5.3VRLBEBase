using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnOverallMeterResults__PythonCallable.OnOverallMeterResults__PythonCallable")]
	public partial class OnOverallMeterResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnOverallMeterResults__PythonCallable.OnOverallMeterResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}