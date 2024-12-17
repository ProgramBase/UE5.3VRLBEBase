using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorEndTouchOverSignature__PythonCallable.ActorEndTouchOverSignature__PythonCallable")]
	public partial class ActorEndTouchOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorEndTouchOverSignature__PythonCallable.ActorEndTouchOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}