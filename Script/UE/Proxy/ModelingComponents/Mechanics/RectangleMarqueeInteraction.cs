using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.RectangleMarqueeInteraction")]
	public partial class URectangleMarqueeInteraction : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.RectangleMarqueeInteraction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}