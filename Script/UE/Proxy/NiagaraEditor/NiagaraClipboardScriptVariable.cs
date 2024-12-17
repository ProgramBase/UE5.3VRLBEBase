using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraClipboardScriptVariable")]
	public partial class FNiagaraClipboardScriptVariable : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraClipboardScriptVariable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraClipboardScriptVariable() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraClipboardScriptVariable() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraClipboardScriptVariable A, FNiagaraClipboardScriptVariable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraClipboardScriptVariable A, FNiagaraClipboardScriptVariable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraClipboardScriptVariable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraScriptVariable ScriptVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScriptVariable, __ReturnBuffer);

					return *(UNiagaraScriptVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScriptVariable, __InBuffer);
				}
			}
		}

		public FGuid OriginalChangeId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OriginalChangeId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OriginalChangeId, __InBuffer);
				}
			}
		}

		private static uint __ScriptVariable = 0;

		private static uint __OriginalChangeId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}