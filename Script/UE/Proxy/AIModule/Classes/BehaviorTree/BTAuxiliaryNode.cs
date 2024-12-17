using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTAuxiliaryNode")]
	public partial class UBTAuxiliaryNode : UBTNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTAuxiliaryNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}