using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeReroute")]
	public partial class UNiagaraNodeReroute : UNiagaraNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeReroute");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}