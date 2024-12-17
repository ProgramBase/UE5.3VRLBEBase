using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AIMoveCompletedSignature__PythonCallable.AIMoveCompletedSignature__PythonCallable")]
	public partial class AIMoveCompletedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AIMoveCompletedSignature__PythonCallable.AIMoveCompletedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}