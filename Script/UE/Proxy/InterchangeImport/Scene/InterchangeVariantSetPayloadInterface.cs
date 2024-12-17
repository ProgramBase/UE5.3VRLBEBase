using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeVariantSetPayloadInterface")]
	public partial class UInterchangeVariantSetPayloadInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeVariantSetPayloadInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InterchangeImport.InterchangeVariantSetPayloadInterface")]
	public interface IInterchangeVariantSetPayloadInterface : IInterface
	{
	}
}