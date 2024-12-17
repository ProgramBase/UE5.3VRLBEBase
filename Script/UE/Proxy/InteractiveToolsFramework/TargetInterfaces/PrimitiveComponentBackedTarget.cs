using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.PrimitiveComponentBackedTarget")]
	public partial class UPrimitiveComponentBackedTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.PrimitiveComponentBackedTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.PrimitiveComponentBackedTarget")]
	public interface IPrimitiveComponentBackedTarget : IInterface
	{
	}
}