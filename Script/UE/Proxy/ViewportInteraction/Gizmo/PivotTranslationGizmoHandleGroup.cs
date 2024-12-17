using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.PivotTranslationGizmoHandleGroup")]
	public partial class UPivotTranslationGizmoHandleGroup : UAxisGizmoHandleGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.PivotTranslationGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}