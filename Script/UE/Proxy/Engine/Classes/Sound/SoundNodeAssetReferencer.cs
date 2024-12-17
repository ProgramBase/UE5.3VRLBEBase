using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundNodeAssetReferencer")]
	public partial class USoundNodeAssetReferencer : USoundNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundNodeAssetReferencer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}