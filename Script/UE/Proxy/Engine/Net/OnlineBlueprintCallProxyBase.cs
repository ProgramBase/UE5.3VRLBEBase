using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.OnlineBlueprintCallProxyBase")]
	public partial class UOnlineBlueprintCallProxyBase : UBlueprintAsyncActionBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.OnlineBlueprintCallProxyBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}