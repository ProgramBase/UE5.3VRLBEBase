using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnObjectImportDoneDynamic__PythonCallable.OnObjectImportDoneDynamic__PythonCallable")]
	public partial class OnObjectImportDoneDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnObjectImportDoneDynamic__PythonCallable.OnObjectImportDoneDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}