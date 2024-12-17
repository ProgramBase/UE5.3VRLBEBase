using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.TraceQueryTestNames")]
	public partial class FTraceQueryTestNames : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.TraceQueryTestNames");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTraceQueryTestNames() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTraceQueryTestNames() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTraceQueryTestNames A, FTraceQueryTestNames B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTraceQueryTestNames A, FTraceQueryTestNames B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTraceQueryTestNames;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ComponentName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentName, __InBuffer);
				}
			}
		}

		public FName PhysicalMaterialName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialName, __InBuffer);
				}
			}
		}

		public FName ActorName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorName, __InBuffer);
				}
			}
		}

		private static uint __ComponentName = 0;

		private static uint __PhysicalMaterialName = 0;

		private static uint __ActorName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}