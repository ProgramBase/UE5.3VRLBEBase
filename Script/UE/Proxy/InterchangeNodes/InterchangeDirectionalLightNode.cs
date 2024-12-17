using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeDirectionalLightNode")]
	public partial class UInterchangeDirectionalLightNode : UInterchangeBaseLightNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeDirectionalLightNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}