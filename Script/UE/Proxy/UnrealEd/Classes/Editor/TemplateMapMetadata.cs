using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TemplateMapMetadata")]
	public partial class UDEPRECATED_TemplateMapMetadata : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TemplateMapMetadata");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}