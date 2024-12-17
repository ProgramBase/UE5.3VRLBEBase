using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDIDataChannelWriteCompiledData")]
	public partial class FNDIDataChannelWriteCompiledData : FNDIDataChannelCompiledData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NDIDataChannelWriteCompiledData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNDIDataChannelWriteCompiledData()
		{
		}

		public static bool operator ==(FNDIDataChannelWriteCompiledData A, FNDIDataChannelWriteCompiledData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNDIDataChannelWriteCompiledData A, FNDIDataChannelWriteCompiledData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNDIDataChannelWriteCompiledData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraDataSetCompiledData DataLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataLayout, __ReturnBuffer);

					return *(FNiagaraDataSetCompiledData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataLayout, __InBuffer);
				}
			}
		}

		private static uint __DataLayout = 0;

	}
}