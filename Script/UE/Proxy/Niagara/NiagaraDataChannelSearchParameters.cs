using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannelSearchParameters")]
	public partial class FNiagaraDataChannelSearchParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDataChannelSearchParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDataChannelSearchParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDataChannelSearchParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDataChannelSearchParameters A, FNiagaraDataChannelSearchParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDataChannelSearchParameters A, FNiagaraDataChannelSearchParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDataChannelSearchParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USceneComponent OwningComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OwningComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OwningComponent, __InBuffer);
				}
			}
		}

		public FVector Location
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Location, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Location, __InBuffer);
				}
			}
		}

		private static uint __OwningComponent = 0;

		private static uint __Location = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}