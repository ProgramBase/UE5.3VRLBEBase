using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ForEachAssetIteratorSignature__PythonCallable.ForEachAssetIteratorSignature__PythonCallable")]
	public partial class ForEachAssetIteratorSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ForEachAssetIteratorSignature__PythonCallable.ForEachAssetIteratorSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}