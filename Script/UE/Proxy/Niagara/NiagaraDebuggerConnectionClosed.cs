using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDebuggerConnectionClosed")]
	public partial class FNiagaraDebuggerConnectionClosed : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDebuggerConnectionClosed");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDebuggerConnectionClosed() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDebuggerConnectionClosed() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDebuggerConnectionClosed A, FNiagaraDebuggerConnectionClosed B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDebuggerConnectionClosed A, FNiagaraDebuggerConnectionClosed B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDebuggerConnectionClosed;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid SessionId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SessionId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SessionId, __InBuffer);
				}
			}
		}

		public FGuid InstanceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstanceId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstanceId, __InBuffer);
				}
			}
		}

		private static uint __SessionId = 0;

		private static uint __InstanceId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}