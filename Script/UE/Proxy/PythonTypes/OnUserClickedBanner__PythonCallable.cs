using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnUserClickedBanner__PythonCallable.OnUserClickedBanner__PythonCallable")]
	public partial class OnUserClickedBanner__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnUserClickedBanner__PythonCallable.OnUserClickedBanner__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}