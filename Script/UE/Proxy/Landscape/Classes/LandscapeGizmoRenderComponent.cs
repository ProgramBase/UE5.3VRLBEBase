using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeGizmoRenderComponent")]
	public partial class ULandscapeGizmoRenderComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeGizmoRenderComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}