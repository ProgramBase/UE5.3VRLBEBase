using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnClaimedResourcesChangeSignature__PythonCallable.OnClaimedResourcesChangeSignature__PythonCallable")]
	public partial class OnClaimedResourcesChangeSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnClaimedResourcesChangeSignature__PythonCallable.OnClaimedResourcesChangeSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}