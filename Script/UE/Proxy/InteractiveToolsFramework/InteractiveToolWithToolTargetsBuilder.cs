using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveToolWithToolTargetsBuilder")]
	public partial class UInteractiveToolWithToolTargetsBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveToolWithToolTargetsBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}