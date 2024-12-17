using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PSCPool")]
	public partial class FPSCPool : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PSCPool");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPSCPool() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPSCPool() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPSCPool A, FPSCPool B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPSCPool A, FPSCPool B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPSCPool;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPSCPoolElem> FreeElements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FreeElements, __ReturnBuffer);

					return *(TArray<FPSCPoolElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FreeElements, __InBuffer);
				}
			}
		}

		private static uint __FreeElements = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}