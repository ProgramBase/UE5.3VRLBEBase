using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraEmitterThumbnailRenderer")]
	public partial class UNiagaraEmitterThumbnailRenderer : UNiagaraThumbnailRendererBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraEmitterThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}