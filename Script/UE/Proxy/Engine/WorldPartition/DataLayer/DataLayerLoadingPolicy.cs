using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataLayerLoadingPolicy")]
	public partial class UDataLayerLoadingPolicy : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataLayerLoadingPolicy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}