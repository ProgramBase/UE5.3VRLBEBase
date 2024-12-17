using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorOnReleasedSignature__PythonCallable.ActorOnReleasedSignature__PythonCallable")]
	public partial class ActorOnReleasedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorOnReleasedSignature__PythonCallable.ActorOnReleasedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}