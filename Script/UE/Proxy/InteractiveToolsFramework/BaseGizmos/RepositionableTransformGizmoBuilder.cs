using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.RepositionableTransformGizmoBuilder")]
	public partial class URepositionableTransformGizmoBuilder : UCombinedTransformGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.RepositionableTransformGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}