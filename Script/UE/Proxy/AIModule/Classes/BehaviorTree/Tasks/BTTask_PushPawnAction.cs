using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTTask_PushPawnAction")]
	public partial class UBTTask_PushPawnAction : UBTTask_PawnActionBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTTask_PushPawnAction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}