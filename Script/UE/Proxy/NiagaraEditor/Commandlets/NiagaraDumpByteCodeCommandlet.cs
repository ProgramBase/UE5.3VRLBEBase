using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraDumpByteCodeCommandlet")]
	public partial class UNiagaraDumpByteCodeCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraDumpByteCodeCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}