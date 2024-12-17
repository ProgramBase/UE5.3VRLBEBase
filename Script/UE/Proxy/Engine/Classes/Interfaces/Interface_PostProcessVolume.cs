using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_PostProcessVolume")]
	public partial class UInterface_PostProcessVolume : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_PostProcessVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_PostProcessVolume")]
	public interface IInterface_PostProcessVolume : IInterface
	{
	}
}