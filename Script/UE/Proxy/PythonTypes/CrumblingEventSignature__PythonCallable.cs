using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/CrumblingEventSignature__PythonCallable.CrumblingEventSignature__PythonCallable")]
	public partial class CrumblingEventSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/CrumblingEventSignature__PythonCallable.CrumblingEventSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}