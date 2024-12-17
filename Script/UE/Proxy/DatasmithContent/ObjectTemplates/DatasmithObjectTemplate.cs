using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithObjectTemplate")]
	public partial class UDatasmithObjectTemplate : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithObjectTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}