using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.VolumeCacheFactory")]
	public partial class UVolumeCacheFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.VolumeCacheFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}