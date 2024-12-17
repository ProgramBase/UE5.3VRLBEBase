using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorOnInputTouchEndSignature__PythonCallable.ActorOnInputTouchEndSignature__PythonCallable")]
	public partial class ActorOnInputTouchEndSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorOnInputTouchEndSignature__PythonCallable.ActorOnInputTouchEndSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}