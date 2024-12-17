using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.TransformGizmoSource")]
	public partial class UTransformGizmoSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.TransformGizmoSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EditorInteractiveToolsFramework.TransformGizmoSource")]
	public interface ITransformGizmoSource : IInterface
	{
	}
}