using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioSingleEnvelopeValue__PythonCallable.OnAudioSingleEnvelopeValue__PythonCallable")]
	public partial class OnAudioSingleEnvelopeValue__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioSingleEnvelopeValue__PythonCallable.OnAudioSingleEnvelopeValue__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}