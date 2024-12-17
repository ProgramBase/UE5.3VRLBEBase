using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveToolExclusiveToolAPI")]
	public partial class UInteractiveToolExclusiveToolAPI : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveToolExclusiveToolAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.InteractiveToolExclusiveToolAPI")]
	public interface IInteractiveToolExclusiveToolAPI : IInterface
	{
	}
}