using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPerChannelLoudnessResults__PythonCallable.OnPerChannelLoudnessResults__PythonCallable")]
	public partial class OnPerChannelLoudnessResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPerChannelLoudnessResults__PythonCallable.OnPerChannelLoudnessResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}