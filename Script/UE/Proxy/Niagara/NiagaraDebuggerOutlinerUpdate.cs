using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDebuggerOutlinerUpdate")]
	public partial class FNiagaraDebuggerOutlinerUpdate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDebuggerOutlinerUpdate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDebuggerOutlinerUpdate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDebuggerOutlinerUpdate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDebuggerOutlinerUpdate A, FNiagaraDebuggerOutlinerUpdate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDebuggerOutlinerUpdate A, FNiagaraDebuggerOutlinerUpdate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDebuggerOutlinerUpdate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraOutlinerData OutlinerData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutlinerData, __ReturnBuffer);

					return *(FNiagaraOutlinerData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutlinerData, __InBuffer);
				}
			}
		}

		private static uint __OutlinerData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}