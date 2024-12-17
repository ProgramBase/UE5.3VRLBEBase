using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.PrimitiveComponentToolTargetFactory")]
	public partial class UPrimitiveComponentToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.PrimitiveComponentToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}