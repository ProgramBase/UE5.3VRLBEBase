using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.FontProviderInterface")]
	public partial class UFontProviderInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SlateCore.FontProviderInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/SlateCore.FontProviderInterface")]
	public interface IFontProviderInterface : IInterface
	{
	}
}