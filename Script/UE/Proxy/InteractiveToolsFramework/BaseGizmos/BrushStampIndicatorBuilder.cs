using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.BrushStampIndicatorBuilder")]
	public partial class UBrushStampIndicatorBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.BrushStampIndicatorBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}