using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDCIsland")]
	public partial class FNDCIsland : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NDCIsland");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNDCIsland() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNDCIsland() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNDCIsland A, FNDCIsland B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNDCIsland A, FNDCIsland B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNDCIsland;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraDataChannelHandler_Islands Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(UNiagaraDataChannelHandler_Islands*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public FBoxSphereBounds Bounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bounds, __ReturnBuffer);

					return *(FBoxSphereBounds*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bounds, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraComponent> NiagaraSystems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NiagaraSystems, __ReturnBuffer);

					return *(TArray<UNiagaraComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NiagaraSystems, __InBuffer);
				}
			}
		}

		private static uint __Owner = 0;

		private static uint __Bounds = 0;

		private static uint __NiagaraSystems = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}