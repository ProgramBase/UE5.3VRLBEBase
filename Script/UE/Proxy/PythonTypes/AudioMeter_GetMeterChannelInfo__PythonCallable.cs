using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AudioMeter_GetMeterChannelInfo__PythonCallable.AudioMeter_GetMeterChannelInfo__PythonCallable")]
	public partial class AudioMeter_GetMeterChannelInfo__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AudioMeter_GetMeterChannelInfo__PythonCallable.AudioMeter_GetMeterChannelInfo__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}