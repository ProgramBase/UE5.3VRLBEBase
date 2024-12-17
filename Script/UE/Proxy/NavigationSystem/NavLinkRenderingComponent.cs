using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavLinkRenderingComponent")]
	public partial class UNavLinkRenderingComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavLinkRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}