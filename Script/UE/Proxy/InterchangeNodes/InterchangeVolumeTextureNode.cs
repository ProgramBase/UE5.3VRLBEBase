using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeVolumeTextureNode")]
	public partial class UInterchangeVolumeTextureNode : UInterchangeTextureNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeVolumeTextureNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}