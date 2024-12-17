using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSystemThumbnailRenderer")]
	public partial class UNiagaraSystemThumbnailRenderer : UNiagaraThumbnailRendererBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraSystemThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}