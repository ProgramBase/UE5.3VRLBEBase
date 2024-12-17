using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveToolNestedAcceptCancelAPI")]
	public partial class UInteractiveToolNestedAcceptCancelAPI : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveToolNestedAcceptCancelAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.InteractiveToolNestedAcceptCancelAPI")]
	public interface IInteractiveToolNestedAcceptCancelAPI : IInterface
	{
	}
}