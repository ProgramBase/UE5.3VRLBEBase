using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioFadeChangeSignature__PythonCallable.OnAudioFadeChangeSignature__PythonCallable")]
	public partial class OnAudioFadeChangeSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioFadeChangeSignature__PythonCallable.OnAudioFadeChangeSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}