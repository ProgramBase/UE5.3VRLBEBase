using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnImportDoneDynamic__PythonCallable.OnImportDoneDynamic__PythonCallable")]
	public partial class OnImportDoneDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnImportDoneDynamic__PythonCallable.OnImportDoneDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}