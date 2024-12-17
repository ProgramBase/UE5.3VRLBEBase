using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScriptUObjectCompileInfo")]
	public partial class FNiagaraScriptUObjectCompileInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraScriptUObjectCompileInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraScriptUObjectCompileInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraScriptUObjectCompileInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraScriptUObjectCompileInfo A, FNiagaraScriptUObjectCompileInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraScriptUObjectCompileInfo A, FNiagaraScriptUObjectCompileInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraScriptUObjectCompileInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariableBase Variable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Variable, __ReturnBuffer);

					return *(FNiagaraVariableBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Variable, __InBuffer);
				}
			}
		}

		public UObject Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		public FSoftObjectPath ObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPath, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPath, __InBuffer);
				}
			}
		}

		public FName RegisteredParameterMapRead
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RegisteredParameterMapRead, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RegisteredParameterMapRead, __InBuffer);
				}
			}
		}

		public TArray<FName> RegisteredParameterMapWrites
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RegisteredParameterMapWrites, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RegisteredParameterMapWrites, __InBuffer);
				}
			}
		}

		private static uint __Variable = 0;

		private static uint __Object = 0;

		private static uint __ObjectPath = 0;

		private static uint __RegisteredParameterMapRead = 0;

		private static uint __RegisteredParameterMapWrites = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}