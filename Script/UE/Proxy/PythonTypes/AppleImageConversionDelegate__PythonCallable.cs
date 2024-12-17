using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AppleImageConversionDelegate__PythonCallable.AppleImageConversionDelegate__PythonCallable")]
	public partial class AppleImageConversionDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AppleImageConversionDelegate__PythonCallable.AppleImageConversionDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}