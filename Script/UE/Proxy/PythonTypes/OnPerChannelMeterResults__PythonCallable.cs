using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPerChannelMeterResults__PythonCallable.OnPerChannelMeterResults__PythonCallable")]
	public partial class OnPerChannelMeterResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPerChannelMeterResults__PythonCallable.OnPerChannelMeterResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}