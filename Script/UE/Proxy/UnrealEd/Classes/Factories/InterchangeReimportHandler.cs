using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.InterchangeReimportHandler")]
	public partial class UInterchangeReimportHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.InterchangeReimportHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}