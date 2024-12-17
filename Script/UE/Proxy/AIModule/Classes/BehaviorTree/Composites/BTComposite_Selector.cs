using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTComposite_Selector")]
	public partial class UBTComposite_Selector : UBTCompositeNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTComposite_Selector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}