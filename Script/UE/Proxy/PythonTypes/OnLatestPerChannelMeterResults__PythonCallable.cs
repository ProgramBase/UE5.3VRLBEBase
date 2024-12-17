using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLatestPerChannelMeterResults__PythonCallable.OnLatestPerChannelMeterResults__PythonCallable")]
	public partial class OnLatestPerChannelMeterResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLatestPerChannelMeterResults__PythonCallable.OnLatestPerChannelMeterResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}