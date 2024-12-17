using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.NamedSlotInterface")]
	public partial class UNamedSlotInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.NamedSlotInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UMG.NamedSlotInterface")]
	public interface INamedSlotInterface : IInterface
	{
	}
}