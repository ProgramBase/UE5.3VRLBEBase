using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTTask_PawnActionBase")]
	public partial class UBTTask_PawnActionBase : UBTTaskNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTTask_PawnActionBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}