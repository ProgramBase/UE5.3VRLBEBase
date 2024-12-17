using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.UniformScaleDragOperation")]
	public partial class UUniformScaleDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.UniformScaleDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}