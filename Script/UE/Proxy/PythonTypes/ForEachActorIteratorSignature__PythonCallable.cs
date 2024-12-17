using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ForEachActorIteratorSignature__PythonCallable.ForEachActorIteratorSignature__PythonCallable")]
	public partial class ForEachActorIteratorSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ForEachActorIteratorSignature__PythonCallable.ForEachActorIteratorSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}