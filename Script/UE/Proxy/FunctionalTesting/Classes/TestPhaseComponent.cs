using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.TestPhaseComponent")]
	public partial class UTestPhaseComponent : USceneComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.TestPhaseComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}