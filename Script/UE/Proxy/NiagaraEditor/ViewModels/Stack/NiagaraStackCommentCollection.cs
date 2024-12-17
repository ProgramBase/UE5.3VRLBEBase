using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackCommentCollection")]
	public partial class UNiagaraStackCommentCollection : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackCommentCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}