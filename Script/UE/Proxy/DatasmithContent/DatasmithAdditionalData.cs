using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithAdditionalData")]
	public partial class UDatasmithAdditionalData : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithAdditionalData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}