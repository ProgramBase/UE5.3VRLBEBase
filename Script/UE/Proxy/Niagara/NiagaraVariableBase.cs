using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraVariableBase")]
	public partial class FNiagaraVariableBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraVariableBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVariableBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraVariableBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraVariableBase A, FNiagaraVariableBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVariableBase A, FNiagaraVariableBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVariableBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FNiagaraTypeDefinitionHandle TypeDefHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TypeDefHandle, __ReturnBuffer);

					return *(FNiagaraTypeDefinitionHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TypeDefHandle, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __TypeDefHandle = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}