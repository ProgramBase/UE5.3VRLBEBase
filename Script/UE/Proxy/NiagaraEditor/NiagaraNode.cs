using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNode")]
	public partial class UNiagaraNode : UEdGraphNode, IStaticClass
	{
		public FGuid ChangeId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChangeId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChangeId, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ChangeId = 0;
	}
}