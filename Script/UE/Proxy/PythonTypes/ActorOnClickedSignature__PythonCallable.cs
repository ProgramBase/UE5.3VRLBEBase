using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorOnClickedSignature__PythonCallable.ActorOnClickedSignature__PythonCallable")]
	public partial class ActorOnClickedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorOnClickedSignature__PythonCallable.ActorOnClickedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}