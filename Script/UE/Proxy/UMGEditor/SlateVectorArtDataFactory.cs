using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.SlateVectorArtDataFactory")]
	public partial class USlateVectorArtDataFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.SlateVectorArtDataFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}