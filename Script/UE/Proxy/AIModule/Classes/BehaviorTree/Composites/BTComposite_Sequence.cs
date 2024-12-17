using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTComposite_Sequence")]
	public partial class UBTComposite_Sequence : UBTCompositeNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTComposite_Sequence");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}