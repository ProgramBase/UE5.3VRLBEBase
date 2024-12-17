using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ImportSubsystem_OnAssetReimport_Dyn__PythonCallable.ImportSubsystem_OnAssetReimport_Dyn__PythonCallable")]
	public partial class ImportSubsystem_OnAssetReimport_Dyn__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ImportSubsystem_OnAssetReimport_Dyn__PythonCallable.ImportSubsystem_OnAssetReimport_Dyn__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}