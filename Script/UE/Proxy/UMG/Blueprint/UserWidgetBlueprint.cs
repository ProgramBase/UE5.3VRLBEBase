using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserWidgetBlueprint")]
	public partial class UUserWidgetBlueprint : UBlueprint, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserWidgetBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}