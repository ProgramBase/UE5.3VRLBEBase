using Script.CoreUObject;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.TypedElementViewportInteraction")]
	public partial class UTypedElementViewportInteraction : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.TypedElementViewportInteraction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}