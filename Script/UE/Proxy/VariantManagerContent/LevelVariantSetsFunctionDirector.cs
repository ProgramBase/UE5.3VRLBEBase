using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.LevelVariantSetsFunctionDirector")]
	public partial class ULevelVariantSetsFunctionDirector : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.LevelVariantSetsFunctionDirector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}