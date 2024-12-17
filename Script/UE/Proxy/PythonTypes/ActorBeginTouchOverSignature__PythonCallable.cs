using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorBeginTouchOverSignature__PythonCallable.ActorBeginTouchOverSignature__PythonCallable")]
	public partial class ActorBeginTouchOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorBeginTouchOverSignature__PythonCallable.ActorBeginTouchOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}