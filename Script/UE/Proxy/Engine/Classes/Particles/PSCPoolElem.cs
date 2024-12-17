using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PSCPoolElem")]
	public partial class FPSCPoolElem : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PSCPoolElem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPSCPoolElem() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPSCPoolElem() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPSCPoolElem A, FPSCPoolElem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPSCPoolElem A, FPSCPoolElem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPSCPoolElem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UParticleSystemComponent PSC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PSC, __ReturnBuffer);

					return *(UParticleSystemComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PSC, __InBuffer);
				}
			}
		}

		private static uint __PSC = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}