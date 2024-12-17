using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecorator_ForceSuccess")]
	public partial class UBTDecorator_ForceSuccess : UBTDecorator, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTDecorator_ForceSuccess");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}