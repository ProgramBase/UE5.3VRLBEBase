using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PawnSensingComponent_HearNoiseDelegate__PythonCallable.PawnSensingComponent_HearNoiseDelegate__PythonCallable")]
	public partial class PawnSensingComponent_HearNoiseDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PawnSensingComponent_HearNoiseDelegate__PythonCallable.PawnSensingComponent_HearNoiseDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}