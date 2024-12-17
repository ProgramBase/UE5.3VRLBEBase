using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.FontFaceInterface")]
	public partial class UFontFaceInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SlateCore.FontFaceInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/SlateCore.FontFaceInterface")]
	public interface IFontFaceInterface : IInterface
	{
	}
}