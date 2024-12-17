using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NCPoolElement")]
	public partial class FNCPoolElement : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NCPoolElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNCPoolElement() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNCPoolElement() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNCPoolElement A, FNCPoolElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNCPoolElement A, FNCPoolElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNCPoolElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraComponent Component
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Component, __ReturnBuffer);

					return *(UNiagaraComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Component, __InBuffer);
				}
			}
		}

		private static uint __Component = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}