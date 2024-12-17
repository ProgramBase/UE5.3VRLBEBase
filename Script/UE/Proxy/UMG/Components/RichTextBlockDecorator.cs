using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.RichTextBlockDecorator")]
	public partial class URichTextBlockDecorator : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.RichTextBlockDecorator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}