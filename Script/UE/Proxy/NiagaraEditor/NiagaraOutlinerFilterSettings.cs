using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraOutlinerFilterSettings")]
	public partial class FNiagaraOutlinerFilterSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraOutlinerFilterSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerFilterSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerFilterSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerFilterSettings A, FNiagaraOutlinerFilterSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerFilterSettings A, FNiagaraOutlinerFilterSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerFilterSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bFilterBySystemExecutionState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFilterBySystemExecutionState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFilterBySystemExecutionState, __InBuffer);
				}
			}
		}

		public bool bFilterByEmitterExecutionState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFilterByEmitterExecutionState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFilterByEmitterExecutionState, __InBuffer);
				}
			}
		}

		public bool bFilterByEmitterSimTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFilterByEmitterSimTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFilterByEmitterSimTarget, __InBuffer);
				}
			}
		}

		public bool bFilterBySystemCullState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFilterBySystemCullState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFilterBySystemCullState, __InBuffer);
				}
			}
		}

		public ENiagaraExecutionState SystemExecutionState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemExecutionState, __ReturnBuffer);

					return *(ENiagaraExecutionState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = (uint)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemExecutionState, __InBuffer);
				}
			}
		}

		public ENiagaraExecutionState EmitterExecutionState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterExecutionState, __ReturnBuffer);

					return *(ENiagaraExecutionState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = (uint)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterExecutionState, __InBuffer);
				}
			}
		}

		public ENiagaraSimTarget EmitterSimTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterSimTarget, __ReturnBuffer);

					return *(ENiagaraSimTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterSimTarget, __InBuffer);
				}
			}
		}

		public bool bSystemCullState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSystemCullState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSystemCullState, __InBuffer);
				}
			}
		}

		private static uint __bFilterBySystemExecutionState = 0;

		private static uint __bFilterByEmitterExecutionState = 0;

		private static uint __bFilterByEmitterSimTarget = 0;

		private static uint __bFilterBySystemCullState = 0;

		private static uint __SystemExecutionState = 0;

		private static uint __EmitterExecutionState = 0;

		private static uint __EmitterSimTarget = 0;

		private static uint __bSystemCullState = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}