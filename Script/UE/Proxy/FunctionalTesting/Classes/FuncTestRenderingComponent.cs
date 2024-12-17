using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.FuncTestRenderingComponent")]
	public partial class UFuncTestRenderingComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.FuncTestRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}