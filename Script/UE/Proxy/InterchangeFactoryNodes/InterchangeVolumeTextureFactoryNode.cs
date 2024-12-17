using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeVolumeTextureFactoryNode")]
	public partial class UInterchangeVolumeTextureFactoryNode : UInterchangeTextureFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeVolumeTextureFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}