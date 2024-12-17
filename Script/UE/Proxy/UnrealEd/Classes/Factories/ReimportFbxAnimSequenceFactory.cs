using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportFbxAnimSequenceFactory")]
	public partial class UReimportFbxAnimSequenceFactory : UFbxFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportFbxAnimSequenceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}