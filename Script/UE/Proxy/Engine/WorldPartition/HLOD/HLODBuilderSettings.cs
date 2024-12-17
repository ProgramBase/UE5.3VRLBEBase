using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HLODBuilderSettings")]
	public partial class UHLODBuilderSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HLODBuilderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}