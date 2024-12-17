using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.BrushAdjusterInputBehavior")]
	public partial class UBrushAdjusterInputBehavior : UAnyButtonInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.BrushAdjusterInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}