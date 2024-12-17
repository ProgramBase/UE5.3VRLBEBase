using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.OverlapResult")]
	public partial class FOverlapResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.OverlapResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FOverlapResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FOverlapResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FOverlapResult A, FOverlapResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FOverlapResult A, FOverlapResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FOverlapResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FActorInstanceHandle OverlapObjectHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverlapObjectHandle, __ReturnBuffer);

					return *(FActorInstanceHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverlapObjectHandle, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UPrimitiveComponent> Component
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Component, __ReturnBuffer);

					return *(TWeakObjectPtr<UPrimitiveComponent>*)__ReturnBuffer;
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

		public bool bBlockingHit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bBlockingHit, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bBlockingHit, __InBuffer);
				}
			}
		}

		private static uint __OverlapObjectHandle = 0;

		private static uint __Component = 0;

		private static uint __bBlockingHit = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}