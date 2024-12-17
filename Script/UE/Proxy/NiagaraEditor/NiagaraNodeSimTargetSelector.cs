using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeSimTargetSelector")]
	public partial class UNiagaraNodeSimTargetSelector : UNiagaraNodeUsageSelector, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeSimTargetSelector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}