using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActiveSoundUpdateInterface")]
	public partial class UActiveSoundUpdateInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActiveSoundUpdateInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.ActiveSoundUpdateInterface")]
	public interface IActiveSoundUpdateInterface : IInterface
	{
	}
}