using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMontageBlendingOutStartedMCDelegate__PythonCallable.OnMontageBlendingOutStartedMCDelegate__PythonCallable")]
	public partial class OnMontageBlendingOutStartedMCDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMontageBlendingOutStartedMCDelegate__PythonCallable.OnMontageBlendingOutStartedMCDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}