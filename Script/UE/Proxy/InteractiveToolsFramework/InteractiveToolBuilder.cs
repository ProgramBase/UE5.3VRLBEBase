using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveToolBuilder")]
	public partial class UInteractiveToolBuilder : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}