using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TexAlignerBox")]
	public partial class UTexAlignerBox : UTexAligner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TexAlignerBox");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}