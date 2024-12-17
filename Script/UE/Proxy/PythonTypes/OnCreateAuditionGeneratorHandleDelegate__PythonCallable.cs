using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnCreateAuditionGeneratorHandleDelegate__PythonCallable.OnCreateAuditionGeneratorHandleDelegate__PythonCallable")]
	public partial class OnCreateAuditionGeneratorHandleDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnCreateAuditionGeneratorHandleDelegate__PythonCallable.OnCreateAuditionGeneratorHandleDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}