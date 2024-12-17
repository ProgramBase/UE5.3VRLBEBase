using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/FlipbookFinishedPlaySignature__PythonCallable.FlipbookFinishedPlaySignature__PythonCallable")]
	public partial class FlipbookFinishedPlaySignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/FlipbookFinishedPlaySignature__PythonCallable.FlipbookFinishedPlaySignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}