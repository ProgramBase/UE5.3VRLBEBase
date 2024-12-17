using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveToolCameraFocusAPI")]
	public partial class UInteractiveToolCameraFocusAPI : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveToolCameraFocusAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.InteractiveToolCameraFocusAPI")]
	public interface IInteractiveToolCameraFocusAPI : IInterface
	{
	}
}