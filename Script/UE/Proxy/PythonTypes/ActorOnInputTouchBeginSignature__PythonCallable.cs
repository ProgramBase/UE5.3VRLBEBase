using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorOnInputTouchBeginSignature__PythonCallable.ActorOnInputTouchBeginSignature__PythonCallable")]
	public partial class ActorOnInputTouchBeginSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorOnInputTouchBeginSignature__PythonCallable.ActorOnInputTouchBeginSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}