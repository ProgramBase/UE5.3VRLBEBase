using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EditorAssetSubsystem_OnExtractAssetFromFileDynamic__PythonCallable.EditorAssetSubsystem_OnExtractAssetFromFileDynamic__PythonCallable")]
	public partial class EditorAssetSubsystem_OnExtractAssetFromFileDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EditorAssetSubsystem_OnExtractAssetFromFileDynamic__PythonCallable.EditorAssetSubsystem_OnExtractAssetFromFileDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}