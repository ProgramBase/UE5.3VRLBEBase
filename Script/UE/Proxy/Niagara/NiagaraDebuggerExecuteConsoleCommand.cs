using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDebuggerExecuteConsoleCommand")]
	public partial class FNiagaraDebuggerExecuteConsoleCommand : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDebuggerExecuteConsoleCommand");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDebuggerExecuteConsoleCommand() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDebuggerExecuteConsoleCommand() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDebuggerExecuteConsoleCommand A, FNiagaraDebuggerExecuteConsoleCommand B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDebuggerExecuteConsoleCommand A, FNiagaraDebuggerExecuteConsoleCommand B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDebuggerExecuteConsoleCommand;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Command
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Command, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Command, __InBuffer);
				}
			}
		}

		public bool bRequiresWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRequiresWorld, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRequiresWorld, __InBuffer);
				}
			}
		}

		private static uint __Command = 0;

		private static uint __bRequiresWorld = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}