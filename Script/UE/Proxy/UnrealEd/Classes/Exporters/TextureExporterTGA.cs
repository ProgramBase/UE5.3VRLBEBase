using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureExporterTGA")]
	public partial class UTextureExporterTGA : UTextureExporterGeneric, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureExporterTGA");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}