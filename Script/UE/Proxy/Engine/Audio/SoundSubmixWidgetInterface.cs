using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundSubmixWidgetInterface")]
	public partial class USoundSubmixWidgetInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundSubmixWidgetInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.SoundSubmixWidgetInterface")]
	public interface ISoundSubmixWidgetInterface : IInterface
	{
		 void OnConstructed(USoundSubmixBase SoundSubmix);
	}
}