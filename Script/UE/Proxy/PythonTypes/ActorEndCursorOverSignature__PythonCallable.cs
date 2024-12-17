using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorEndCursorOverSignature__PythonCallable.ActorEndCursorOverSignature__PythonCallable")]
	public partial class ActorEndCursorOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorEndCursorOverSignature__PythonCallable.ActorEndCursorOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}