using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorHitSignature__PythonCallable.ActorHitSignature__PythonCallable")]
	public partial class ActorHitSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorHitSignature__PythonCallable.ActorHitSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}