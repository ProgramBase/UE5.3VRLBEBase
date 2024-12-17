using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLatestPerChannelLoudnessResults__PythonCallable.OnLatestPerChannelLoudnessResults__PythonCallable")]
	public partial class OnLatestPerChannelLoudnessResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLatestPerChannelLoudnessResults__PythonCallable.OnLatestPerChannelLoudnessResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}