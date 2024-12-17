using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AnimBoneCompressionSettingsFactory")]
	public partial class UAnimBoneCompressionSettingsFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AnimBoneCompressionSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}