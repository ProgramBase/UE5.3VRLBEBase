using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DataflowEnginePlugin
{
	[PathName("/Script/DataflowEnginePlugin.DataflowComponent")]
	public partial class UDataflowComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataflowEnginePlugin.DataflowComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}